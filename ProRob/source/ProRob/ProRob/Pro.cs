using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Threading;

namespace ProRob
{
    public partial class Pro : Form
    {
        public string sourceFilePath;
        public string modelFilePath;
        public DataTable dtmod;
        public int srcSheetNum = 2;

        public Pro()
        {
            InitializeComponent();
        }

        public void init()
        {
            modelFilePath = getApplicationPath() + "/" + GetConfigValue("appSettings", "modFileName");
            
            try
            {
                string str_srcSheetNum = GetConfigValue("appSettings", "srcSheetNum");
                srcSheetNum = Int32.Parse(str_srcSheetNum);
            }
            catch (Exception e) { }
        }
        public String getApplicationPath()
        {
            System.Reflection.Assembly curPath = System.Reflection.Assembly.GetExecutingAssembly();
            String path = curPath.Location;
            path = Path.GetDirectoryName(path);
            return path;
        }


        public string GetOutFilePath(string path)
        {
            string parent = Path.GetDirectoryName(path);
            string fileName = Path.GetFileNameWithoutExtension(path);
            string addName = GetConfigValue("appSettings", "addName");
            string extension = Path.GetExtension(modelFilePath);
            return Path.Combine(parent, fileName + addName + extension);
        }

        public string GetConfigValue(string group, string appKey)
        {
            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.Load(System.Windows.Forms.Application.ExecutablePath + ".config");
                XmlNode xNode;
                XmlElement xElem;
                xNode = xDoc.SelectSingleNode("//" + group);
                xElem = (XmlElement)xNode.SelectSingleNode("//add[@key='" + appKey + "']");
                if (xElem != null)
                    return xElem.GetAttribute("value");
                else
                    return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        private delegate void Active();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Pro());
        }

        private void bt_opensource_Click(object sender, EventArgs e)
        {
            OpenFileDialog F = new OpenFileDialog();
            if (F.ShowDialog() == DialogResult.OK)
            {
                sourceFilePath = F.FileName;
                tb_source.Text = sourceFilePath;
            }
        }

        private void bt_start_Click(object sender, EventArgs e)
        {

            Thread start = new Thread(new ThreadStart(delegate() {

                this.Invoke(new Active(delegate
                {
                    bt_start.Enabled = false;
                    list_log.Items.Add(getTime()+"开始加载文件");
                }));

                DataTable dt_src;
                try {
                    dt_src = NpoiHelper.ImportExcel2007toDt(sourceFilePath, 2);
                }
                catch (Exception ex) {
                    MessageBox.Show(sourceFilePath+"-->打开失败，请确认此文件没有被打开");
                    this.Invoke(new Active(delegate
                    {
                        list_log.Items.Add(getTime() + "出现异常：" + e.ToString());
                        list_log.Items.Add("");
                        bt_start.Enabled = true;
                    }));
                    return;
                }

                if(dtmod == null)
                    try
                    {
                        dtmod = NpoiHelper.ImportExcel2007toDt(modelFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(modelFilePath + "-->打开失败，请确认此文件没有被打开");
                        this.Invoke(new Active(delegate
                        {
                            list_log.Items.Add(getTime() + "出现异常：" + e.ToString());
                            list_log.Items.Add("");
                            bt_start.Enabled = true;
                        }));
                        return;
                    }
                    

                this.Invoke(new Active(delegate
                {
                    list_log.Items.Add(getTime() + "文件加载完毕");
                    list_log.Items.Add(getTime() + "开始关联数据");
                }));

                if (dt_src.Columns.Count < 2)
                {
                    this.Invoke(new Active(delegate
                    {
                        MessageBox.Show(sourceFilePath + "-->分析失败，请输入正确格式的文件");
                        list_log.Items.Add(getTime() + "请输入正确格式的文件");
                        list_log.Items.Add("");
                        bt_start.Enabled = true;
                    }));
                    return;
                }
                    

                DataTable dt_mod = dtmod.Copy();
                DataSet ds = new DataSet();

                ds.Tables.Add(dt_mod);
                ds.Tables.Add(dt_src);

                ds.Relations.Add("dt", dt_mod.Columns[1], dt_src.Columns[1], false);
                DataTable dt = ds.Relations["dt"].ParentTable;

                int[][] data = new int[dt.Rows.Count+1][];
                data[0] = new int[] { 0, 0 };
                int m = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow[] drs = dt.Rows[i].GetChildRows("dt");
                    if (drs.Length > 0)
                    {
                        data[m] = new int[2];
                        data[m][0] = i + 1;
                        data[m][1] = 0;
                        m++;
                    }
                }
                
                this.Invoke(new Active(delegate
                {
                    list_log.Items.Add(getTime() + "关联数据完毕");
                    list_log.Items.Add(getTime() + "载入文件总数：" + dt_src.Rows.Count + "; 匹配行数为:" + (m-1));
                    list_log.Items.Add(getTime() + "开始写入文件");
                }));

                string outPath = GetOutFilePath(sourceFilePath);
                try {
                    NpoiHelper.DoWork(outPath, modelFilePath, data);
                }
                catch (Exception ex) {
                    MessageBox.Show(outPath + "-->文件写入失败，请查看此目录是否具有写权限");
                    this.Invoke(new Active(delegate
                    {
                        list_log.Items.Add(getTime() + "出现异常：" + e.ToString());
                        list_log.Items.Add("");
                        bt_start.Enabled = true;
                    }));
                    return;
                }
                
                this.Invoke(new Active(delegate
                {
                    list_log.Items.Add(getTime() + "写入文件完毕"); 
                    list_log.Items.Add("");
                    bt_start.Enabled = true;
                }));
            }));

            start.Start();
        }

        public string getTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":";
        }

        private void Pro_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
