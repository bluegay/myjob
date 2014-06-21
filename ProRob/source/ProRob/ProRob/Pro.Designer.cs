namespace ProRob
{
    partial class Pro
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab_help = new DevComponents.DotNetBar.TabItem(this.components);
            this.tab_log = new DevComponents.DotNetBar.TabItem(this.components);
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.list_log = new System.Windows.Forms.ListBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.bt_start = new DevComponents.DotNetBar.ButtonX();
            this.bt_opensource = new DevComponents.DotNetBar.ButtonX();
            this.tb_source = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.superTabControl1.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_help
            // 
            this.tab_help.Name = "tab_help";
            this.tab_help.Text = "使用说明";
            // 
            // tab_log
            // 
            this.tab_log.Name = "tab_log";
            this.tab_log.Text = "日志信息";
            // 
            // superTabControl1
            // 
            this.superTabControl1.AntiAlias = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Controls.Add(this.superTabControlPanel1);
            this.superTabControl1.Location = new System.Drawing.Point(26, 73);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 0;
            this.superTabControl1.Size = new System.Drawing.Size(689, 387);
            this.superTabControl1.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superTabControl1.TabIndex = 8;
            this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem1});
            this.superTabControl1.Text = "superTabControl1";
            // 
            // superTabItem1
            // 
            this.superTabItem1.AttachedControl = this.superTabControlPanel1;
            this.superTabItem1.GlobalItem = false;
            this.superTabItem1.Name = "superTabItem1";
            this.superTabItem1.Text = "日志信息";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.list_log);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(689, 359);
            this.superTabControlPanel1.TabIndex = 1;
            this.superTabControlPanel1.TabItem = this.superTabItem1;
            // 
            // list_log
            // 
            this.list_log.BackColor = System.Drawing.SystemColors.Menu;
            this.list_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_log.FormattingEnabled = true;
            this.list_log.ItemHeight = 12;
            this.list_log.Location = new System.Drawing.Point(0, 0);
            this.list_log.Name = "list_log";
            this.list_log.Size = new System.Drawing.Size(689, 359);
            this.list_log.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.bt_start);
            this.groupPanel1.Controls.Add(this.bt_opensource);
            this.groupPanel1.Controls.Add(this.tb_source);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(26, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(689, 55);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 9;
            // 
            // bt_start
            // 
            this.bt_start.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_start.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_start.Location = new System.Drawing.Point(576, 12);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_start.TabIndex = 10;
            this.bt_start.Text = "开始执行";
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_opensource
            // 
            this.bt_opensource.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_opensource.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_opensource.Location = new System.Drawing.Point(520, 12);
            this.bt_opensource.Name = "bt_opensource";
            this.bt_opensource.Size = new System.Drawing.Size(50, 23);
            this.bt_opensource.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_opensource.TabIndex = 9;
            this.bt_opensource.Text = "浏览";
            this.bt_opensource.Click += new System.EventHandler(this.bt_opensource_Click);
            // 
            // tb_source
            // 
            // 
            // 
            // 
            this.tb_source.Border.Class = "TextBoxBorder";
            this.tb_source.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_source.Location = new System.Drawing.Point(80, 13);
            this.tb_source.Name = "tb_source";
            this.tb_source.ReadOnly = true;
            this.tb_source.Size = new System.Drawing.Size(434, 21);
            this.tb_source.TabIndex = 8;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(62, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "文件路径:";
            // 
            // Pro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(741, 487);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.superTabControl1);
            this.Name = "Pro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProRob组学分析软件";
            this.Load += new System.EventHandler(this.Pro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.superTabControl1.ResumeLayout(false);
            this.superTabControlPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabItem tab_help;
        private DevComponents.DotNetBar.TabItem tab_log;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private System.Windows.Forms.ListBox list_log;
        private DevComponents.DotNetBar.SuperTabItem superTabItem1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX bt_start;
        private DevComponents.DotNetBar.ButtonX bt_opensource;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_source;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}

