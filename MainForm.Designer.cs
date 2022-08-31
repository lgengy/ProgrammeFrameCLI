
namespace ProgrammeFrameCLI
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_ProgrameName = new System.Windows.Forms.Label();
            this.txt_ProgrammeName = new System.Windows.Forms.TextBox();
            this.lbl_ProgrammeDir = new System.Windows.Forms.Label();
            this.txt_ProgrammeDir = new System.Windows.Forms.TextBox();
            this.lbl_ProgrammeDirSelected = new System.Windows.Forms.Label();
            this.pnl_Config_BaseInfo = new System.Windows.Forms.Panel();
            this.pnl_InitialUI = new System.Windows.Forms.Panel();
            this.lbl_Tip_NameSpaceName = new System.Windows.Forms.Label();
            this.lbl_Tip_ClassName = new System.Windows.Forms.Label();
            this.txt_ClassName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_NameSpaceName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Tip_ResourcesDir = new System.Windows.Forms.Label();
            this.lbl_Tip_UIInitialCode = new System.Windows.Forms.Label();
            this.lbl_ResourcesDirSelected = new System.Windows.Forms.Label();
            this.txt_ResourcesDir = new System.Windows.Forms.TextBox();
            this.lbl_ResourcesDir = new System.Windows.Forms.Label();
            this.lbl_UIInitialCodeSelected = new System.Windows.Forms.Label();
            this.txt_UIInitialCodeLocate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_InitialUI = new System.Windows.Forms.CheckBox();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.cb_GitSelect = new System.Windows.Forms.CheckBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK_BaseInfo = new System.Windows.Forms.Button();
            this.pnl_Config_AvailableUtils = new System.Windows.Forms.Panel();
            this.cb_UtilsAll = new System.Windows.Forms.CheckBox();
            this.flp_AvailableUtils = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back_BaseInfo = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_Setting = new System.Windows.Forms.Panel();
            this.lbl_Select_ProjectLocate = new System.Windows.Forms.Label();
            this.txt_ProjectLocate = new System.Windows.Forms.TextBox();
            this.lbl_Select_ProgrammeFrameLocate = new System.Windows.Forms.Label();
            this.txt_ProgrammeFrameLocate = new System.Windows.Forms.TextBox();
            this.lbl_Select_GitInstallDir = new System.Windows.Forms.Label();
            this.txt_GitInstallDir = new System.Windows.Forms.TextBox();
            this.lbl_Select_VSInstallDir = new System.Windows.Forms.Label();
            this.txt_VSInstallDir = new System.Windows.Forms.TextBox();
            this.btn_Back_BaseInfo_Setting = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Config_BaseInfo.SuspendLayout();
            this.pnl_InitialUI.SuspendLayout();
            this.pnl_Config_AvailableUtils.SuspendLayout();
            this.flp_AvailableUtils.SuspendLayout();
            this.pnl_Setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ProgrameName
            // 
            this.lbl_ProgrameName.AutoSize = true;
            this.lbl_ProgrameName.Location = new System.Drawing.Point(21, 27);
            this.lbl_ProgrameName.Name = "lbl_ProgrameName";
            this.lbl_ProgrameName.Size = new System.Drawing.Size(53, 12);
            this.lbl_ProgrameName.TabIndex = 0;
            this.lbl_ProgrameName.Text = "项目名称";
            // 
            // txt_ProgrammeName
            // 
            this.txt_ProgrammeName.Location = new System.Drawing.Point(23, 56);
            this.txt_ProgrammeName.Name = "txt_ProgrammeName";
            this.txt_ProgrammeName.Size = new System.Drawing.Size(412, 21);
            this.txt_ProgrammeName.TabIndex = 1;
            this.txt_ProgrammeName.TextChanged += new System.EventHandler(this.Txt_ProgrammeDirInfo_TextChanged);
            // 
            // lbl_ProgrammeDir
            // 
            this.lbl_ProgrammeDir.AutoSize = true;
            this.lbl_ProgrammeDir.Location = new System.Drawing.Point(21, 105);
            this.lbl_ProgrammeDir.Name = "lbl_ProgrammeDir";
            this.lbl_ProgrammeDir.Size = new System.Drawing.Size(53, 12);
            this.lbl_ProgrammeDir.TabIndex = 2;
            this.lbl_ProgrammeDir.Text = "项目位置";
            // 
            // txt_ProgrammeDir
            // 
            this.txt_ProgrammeDir.Location = new System.Drawing.Point(23, 133);
            this.txt_ProgrammeDir.Name = "txt_ProgrammeDir";
            this.txt_ProgrammeDir.Size = new System.Drawing.Size(412, 21);
            this.txt_ProgrammeDir.TabIndex = 2;
            this.txt_ProgrammeDir.TextChanged += new System.EventHandler(this.Txt_ProgrammeDirInfo_TextChanged);
            // 
            // lbl_ProgrammeDirSelected
            // 
            this.lbl_ProgrammeDirSelected.BackColor = System.Drawing.Color.LightGray;
            this.lbl_ProgrammeDirSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ProgrammeDirSelected.Location = new System.Drawing.Point(441, 133);
            this.lbl_ProgrammeDirSelected.Name = "lbl_ProgrammeDirSelected";
            this.lbl_ProgrammeDirSelected.Size = new System.Drawing.Size(25, 21);
            this.lbl_ProgrammeDirSelected.TabIndex = 3;
            this.lbl_ProgrammeDirSelected.Text = "...";
            this.lbl_ProgrammeDirSelected.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_ProgrammeDirSelected.Click += new System.EventHandler(this.Lbl_ProgrammeDirSelected_Click);
            // 
            // pnl_Config_BaseInfo
            // 
            this.pnl_Config_BaseInfo.Controls.Add(this.pnl_InitialUI);
            this.pnl_Config_BaseInfo.Controls.Add(this.cb_InitialUI);
            this.pnl_Config_BaseInfo.Controls.Add(this.btn_Setting);
            this.pnl_Config_BaseInfo.Controls.Add(this.cb_GitSelect);
            this.pnl_Config_BaseInfo.Controls.Add(this.btn_Cancel);
            this.pnl_Config_BaseInfo.Controls.Add(this.btn_OK_BaseInfo);
            this.pnl_Config_BaseInfo.Controls.Add(this.txt_ProgrammeName);
            this.pnl_Config_BaseInfo.Controls.Add(this.lbl_ProgrammeDirSelected);
            this.pnl_Config_BaseInfo.Controls.Add(this.lbl_ProgrameName);
            this.pnl_Config_BaseInfo.Controls.Add(this.txt_ProgrammeDir);
            this.pnl_Config_BaseInfo.Controls.Add(this.lbl_ProgrammeDir);
            this.pnl_Config_BaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Config_BaseInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Config_BaseInfo.Name = "pnl_Config_BaseInfo";
            this.pnl_Config_BaseInfo.Size = new System.Drawing.Size(800, 450);
            this.pnl_Config_BaseInfo.TabIndex = 4;
            // 
            // pnl_InitialUI
            // 
            this.pnl_InitialUI.Controls.Add(this.lbl_Tip_NameSpaceName);
            this.pnl_InitialUI.Controls.Add(this.lbl_Tip_ClassName);
            this.pnl_InitialUI.Controls.Add(this.txt_ClassName);
            this.pnl_InitialUI.Controls.Add(this.label8);
            this.pnl_InitialUI.Controls.Add(this.txt_NameSpaceName);
            this.pnl_InitialUI.Controls.Add(this.label7);
            this.pnl_InitialUI.Controls.Add(this.lbl_Tip_ResourcesDir);
            this.pnl_InitialUI.Controls.Add(this.lbl_Tip_UIInitialCode);
            this.pnl_InitialUI.Controls.Add(this.lbl_ResourcesDirSelected);
            this.pnl_InitialUI.Controls.Add(this.txt_ResourcesDir);
            this.pnl_InitialUI.Controls.Add(this.lbl_ResourcesDir);
            this.pnl_InitialUI.Controls.Add(this.lbl_UIInitialCodeSelected);
            this.pnl_InitialUI.Controls.Add(this.txt_UIInitialCodeLocate);
            this.pnl_InitialUI.Controls.Add(this.label6);
            this.pnl_InitialUI.Location = new System.Drawing.Point(12, 201);
            this.pnl_InitialUI.Name = "pnl_InitialUI";
            this.pnl_InitialUI.Size = new System.Drawing.Size(776, 103);
            this.pnl_InitialUI.TabIndex = 9;
            this.pnl_InitialUI.Visible = false;
            // 
            // lbl_Tip_NameSpaceName
            // 
            this.lbl_Tip_NameSpaceName.AutoSize = true;
            this.lbl_Tip_NameSpaceName.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tip_NameSpaceName.Location = new System.Drawing.Point(72, 33);
            this.lbl_Tip_NameSpaceName.Name = "lbl_Tip_NameSpaceName";
            this.lbl_Tip_NameSpaceName.Size = new System.Drawing.Size(137, 12);
            this.lbl_Tip_NameSpaceName.TabIndex = 15;
            this.lbl_Tip_NameSpaceName.Text = "请输入所用界面代码包名";
            this.lbl_Tip_NameSpaceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Tip_ClassName
            // 
            this.lbl_Tip_ClassName.AutoSize = true;
            this.lbl_Tip_ClassName.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tip_ClassName.Location = new System.Drawing.Point(72, 81);
            this.lbl_Tip_ClassName.Name = "lbl_Tip_ClassName";
            this.lbl_Tip_ClassName.Size = new System.Drawing.Size(137, 12);
            this.lbl_Tip_ClassName.TabIndex = 14;
            this.lbl_Tip_ClassName.Text = "请输入所用界面代码类名";
            this.lbl_Tip_ClassName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ClassName
            // 
            this.txt_ClassName.Location = new System.Drawing.Point(72, 58);
            this.txt_ClassName.Name = "txt_ClassName";
            this.txt_ClassName.Size = new System.Drawing.Size(137, 21);
            this.txt_ClassName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "类    名：";
            // 
            // txt_NameSpaceName
            // 
            this.txt_NameSpaceName.Location = new System.Drawing.Point(72, 9);
            this.txt_NameSpaceName.Name = "txt_NameSpaceName";
            this.txt_NameSpaceName.Size = new System.Drawing.Size(137, 21);
            this.txt_NameSpaceName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "包    名：";
            // 
            // lbl_Tip_ResourcesDir
            // 
            this.lbl_Tip_ResourcesDir.AutoSize = true;
            this.lbl_Tip_ResourcesDir.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tip_ResourcesDir.Location = new System.Drawing.Point(290, 80);
            this.lbl_Tip_ResourcesDir.Name = "lbl_Tip_ResourcesDir";
            this.lbl_Tip_ResourcesDir.Size = new System.Drawing.Size(137, 12);
            this.lbl_Tip_ResourcesDir.TabIndex = 9;
            this.lbl_Tip_ResourcesDir.Text = "请选择资源文件所在目录";
            this.lbl_Tip_ResourcesDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Tip_UIInitialCode
            // 
            this.lbl_Tip_UIInitialCode.AutoSize = true;
            this.lbl_Tip_UIInitialCode.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tip_UIInitialCode.Location = new System.Drawing.Point(290, 32);
            this.lbl_Tip_UIInitialCode.Name = "lbl_Tip_UIInitialCode";
            this.lbl_Tip_UIInitialCode.Size = new System.Drawing.Size(173, 12);
            this.lbl_Tip_UIInitialCode.TabIndex = 8;
            this.lbl_Tip_UIInitialCode.Text = "请选择初始化所使用的界面代码";
            this.lbl_Tip_UIInitialCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ResourcesDirSelected
            // 
            this.lbl_ResourcesDirSelected.BackColor = System.Drawing.Color.LightGray;
            this.lbl_ResourcesDirSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_ResourcesDirSelected.Location = new System.Drawing.Point(658, 52);
            this.lbl_ResourcesDirSelected.Name = "lbl_ResourcesDirSelected";
            this.lbl_ResourcesDirSelected.Size = new System.Drawing.Size(25, 21);
            this.lbl_ResourcesDirSelected.TabIndex = 7;
            this.lbl_ResourcesDirSelected.Text = "...";
            this.lbl_ResourcesDirSelected.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_ResourcesDirSelected.Click += new System.EventHandler(this.Lbl_ProgrammeDirSelected_Click);
            // 
            // txt_ResourcesDir
            // 
            this.txt_ResourcesDir.Enabled = false;
            this.txt_ResourcesDir.Location = new System.Drawing.Point(290, 56);
            this.txt_ResourcesDir.Name = "txt_ResourcesDir";
            this.txt_ResourcesDir.Size = new System.Drawing.Size(362, 21);
            this.txt_ResourcesDir.TabIndex = 6;
            // 
            // lbl_ResourcesDir
            // 
            this.lbl_ResourcesDir.AutoSize = true;
            this.lbl_ResourcesDir.Location = new System.Drawing.Point(228, 61);
            this.lbl_ResourcesDir.Name = "lbl_ResourcesDir";
            this.lbl_ResourcesDir.Size = new System.Drawing.Size(65, 12);
            this.lbl_ResourcesDir.TabIndex = 5;
            this.lbl_ResourcesDir.Text = "资源目录：";
            // 
            // lbl_UIInitialCodeSelected
            // 
            this.lbl_UIInitialCodeSelected.BackColor = System.Drawing.Color.LightGray;
            this.lbl_UIInitialCodeSelected.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_UIInitialCodeSelected.Location = new System.Drawing.Point(658, 9);
            this.lbl_UIInitialCodeSelected.Name = "lbl_UIInitialCodeSelected";
            this.lbl_UIInitialCodeSelected.Size = new System.Drawing.Size(25, 21);
            this.lbl_UIInitialCodeSelected.TabIndex = 4;
            this.lbl_UIInitialCodeSelected.Text = "...";
            this.lbl_UIInitialCodeSelected.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_UIInitialCodeSelected.Click += new System.EventHandler(this.Lbl_UIInitialCodeSelected_Click);
            // 
            // txt_UIInitialCodeLocate
            // 
            this.txt_UIInitialCodeLocate.Enabled = false;
            this.txt_UIInitialCodeLocate.Location = new System.Drawing.Point(290, 9);
            this.txt_UIInitialCodeLocate.Name = "txt_UIInitialCodeLocate";
            this.txt_UIInitialCodeLocate.Size = new System.Drawing.Size(362, 21);
            this.txt_UIInitialCodeLocate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "界面代码：";
            // 
            // cb_InitialUI
            // 
            this.cb_InitialUI.AutoSize = true;
            this.cb_InitialUI.Location = new System.Drawing.Point(131, 172);
            this.cb_InitialUI.Name = "cb_InitialUI";
            this.cb_InitialUI.Size = new System.Drawing.Size(84, 16);
            this.cb_InitialUI.TabIndex = 8;
            this.cb_InitialUI.Text = "初始化界面";
            this.cb_InitialUI.UseVisualStyleBackColor = true;
            this.cb_InitialUI.CheckedChanged += new System.EventHandler(this.Cb_InitialUI_CheckedChanged);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.White;
            this.btn_Setting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Setting.BackgroundImage")));
            this.btn_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Setting.Location = new System.Drawing.Point(766, 0);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(34, 31);
            this.btn_Setting.TabIndex = 7;
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.Btn_Setting_Click);
            // 
            // cb_GitSelect
            // 
            this.cb_GitSelect.AutoSize = true;
            this.cb_GitSelect.Checked = true;
            this.cb_GitSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_GitSelect.Location = new System.Drawing.Point(23, 172);
            this.cb_GitSelect.Name = "cb_GitSelect";
            this.cb_GitSelect.Size = new System.Drawing.Size(90, 16);
            this.cb_GitSelect.TabIndex = 6;
            this.cb_GitSelect.Text = "初始化git库";
            this.cb_GitSelect.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(713, 410);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_OK_BaseInfo
            // 
            this.btn_OK_BaseInfo.Enabled = false;
            this.btn_OK_BaseInfo.Location = new System.Drawing.Point(632, 410);
            this.btn_OK_BaseInfo.Name = "btn_OK_BaseInfo";
            this.btn_OK_BaseInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_OK_BaseInfo.TabIndex = 4;
            this.btn_OK_BaseInfo.Text = "下一步";
            this.btn_OK_BaseInfo.UseVisualStyleBackColor = true;
            this.btn_OK_BaseInfo.Click += new System.EventHandler(this.Btn_OK_BaseInfo_Click);
            // 
            // pnl_Config_AvailableUtils
            // 
            this.pnl_Config_AvailableUtils.AutoSize = true;
            this.pnl_Config_AvailableUtils.Controls.Add(this.cb_UtilsAll);
            this.pnl_Config_AvailableUtils.Controls.Add(this.flp_AvailableUtils);
            this.pnl_Config_AvailableUtils.Controls.Add(this.label1);
            this.pnl_Config_AvailableUtils.Controls.Add(this.btn_Back_BaseInfo);
            this.pnl_Config_AvailableUtils.Controls.Add(this.btn_OK);
            this.pnl_Config_AvailableUtils.Location = new System.Drawing.Point(0, 0);
            this.pnl_Config_AvailableUtils.Name = "pnl_Config_AvailableUtils";
            this.pnl_Config_AvailableUtils.Size = new System.Drawing.Size(800, 450);
            this.pnl_Config_AvailableUtils.TabIndex = 7;
            this.pnl_Config_AvailableUtils.Visible = false;
            // 
            // cb_UtilsAll
            // 
            this.cb_UtilsAll.AutoSize = true;
            this.cb_UtilsAll.Location = new System.Drawing.Point(15, 374);
            this.cb_UtilsAll.Name = "cb_UtilsAll";
            this.cb_UtilsAll.Size = new System.Drawing.Size(48, 16);
            this.cb_UtilsAll.TabIndex = 8;
            this.cb_UtilsAll.Text = "全选";
            this.cb_UtilsAll.UseVisualStyleBackColor = true;
            this.cb_UtilsAll.CheckedChanged += new System.EventHandler(this.Cb_UtilsAll_CheckedChanged);
            // 
            // flp_AvailableUtils
            // 
            this.flp_AvailableUtils.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_AvailableUtils.AutoScroll = true;
            this.flp_AvailableUtils.Controls.Add(this.checkBox1);
            this.flp_AvailableUtils.Controls.Add(this.checkBox2);
            this.flp_AvailableUtils.Location = new System.Drawing.Point(15, 38);
            this.flp_AvailableUtils.Name = "flp_AvailableUtils";
            this.flp_AvailableUtils.Size = new System.Drawing.Size(773, 329);
            this.flp_AvailableUtils.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.checkBox1.BackgroundImage = global::ProgrammeFrameCLI.Properties.Resources.availableUtils;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Location = new System.Drawing.Point(8, 12);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 140);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "这是一个测试功能";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBox2.BackgroundImage = global::ProgrammeFrameCLI.Properties.Resources.availableUtils;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(134, 12);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(8, 12, 8, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(110, 140);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "这是一个测试功能";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "可选配置";
            // 
            // btn_Back_BaseInfo
            // 
            this.btn_Back_BaseInfo.Location = new System.Drawing.Point(713, 410);
            this.btn_Back_BaseInfo.Name = "btn_Back_BaseInfo";
            this.btn_Back_BaseInfo.Size = new System.Drawing.Size(75, 23);
            this.btn_Back_BaseInfo.TabIndex = 5;
            this.btn_Back_BaseInfo.Text = "返回";
            this.btn_Back_BaseInfo.UseVisualStyleBackColor = true;
            this.btn_Back_BaseInfo.Click += new System.EventHandler(this.Btn_Back_BaseInfo_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(632, 410);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            // 
            // pnl_Setting
            // 
            this.pnl_Setting.Controls.Add(this.lbl_Select_ProjectLocate);
            this.pnl_Setting.Controls.Add(this.lbl_Select_ProgrammeFrameLocate);
            this.pnl_Setting.Controls.Add(this.lbl_Select_GitInstallDir);
            this.pnl_Setting.Controls.Add(this.lbl_Select_VSInstallDir);
            this.pnl_Setting.Controls.Add(this.btn_Back_BaseInfo_Setting);
            this.pnl_Setting.Controls.Add(this.txt_ProgrammeFrameLocate);
            this.pnl_Setting.Controls.Add(this.txt_GitInstallDir);
            this.pnl_Setting.Controls.Add(this.txt_VSInstallDir);
            this.pnl_Setting.Controls.Add(this.txt_ProjectLocate);
            this.pnl_Setting.Controls.Add(this.label5);
            this.pnl_Setting.Controls.Add(this.label4);
            this.pnl_Setting.Controls.Add(this.label3);
            this.pnl_Setting.Controls.Add(this.label2);
            this.pnl_Setting.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Setting.Location = new System.Drawing.Point(0, 0);
            this.pnl_Setting.Name = "pnl_Setting";
            this.pnl_Setting.Size = new System.Drawing.Size(800, 450);
            this.pnl_Setting.TabIndex = 7;
            this.pnl_Setting.Visible = false;
            // 
            // lbl_Select_ProjectLocate
            // 
            this.lbl_Select_ProjectLocate.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Select_ProjectLocate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Select_ProjectLocate.Location = new System.Drawing.Point(633, 35);
            this.lbl_Select_ProjectLocate.Name = "lbl_Select_ProjectLocate";
            this.lbl_Select_ProjectLocate.Size = new System.Drawing.Size(25, 21);
            this.lbl_Select_ProjectLocate.TabIndex = 12;
            this.lbl_Select_ProjectLocate.Tag = this.txt_ProjectLocate;
            this.lbl_Select_ProjectLocate.Text = "...";
            this.lbl_Select_ProjectLocate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Select_ProjectLocate.Click += new System.EventHandler(this.Lbl_Select_SettingLocate_Click);
            // 
            // txt_ProjectLocate
            // 
            this.txt_ProjectLocate.Location = new System.Drawing.Point(159, 35);
            this.txt_ProjectLocate.Name = "txt_ProjectLocate";
            this.txt_ProjectLocate.Size = new System.Drawing.Size(466, 21);
            this.txt_ProjectLocate.TabIndex = 4;
            this.txt_ProjectLocate.TextChanged += new System.EventHandler(this.Txt_Select_SettingLocate_TextChanged);
            // 
            // lbl_Select_ProgrammeFrameLocate
            // 
            this.lbl_Select_ProgrammeFrameLocate.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Select_ProgrammeFrameLocate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Select_ProgrammeFrameLocate.Location = new System.Drawing.Point(633, 75);
            this.lbl_Select_ProgrammeFrameLocate.Name = "lbl_Select_ProgrammeFrameLocate";
            this.lbl_Select_ProgrammeFrameLocate.Size = new System.Drawing.Size(25, 21);
            this.lbl_Select_ProgrammeFrameLocate.TabIndex = 11;
            this.lbl_Select_ProgrammeFrameLocate.Tag = this.txt_ProgrammeFrameLocate;
            this.lbl_Select_ProgrammeFrameLocate.Text = "...";
            this.lbl_Select_ProgrammeFrameLocate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Select_ProgrammeFrameLocate.Click += new System.EventHandler(this.Lbl_Select_SettingLocate_Click);
            // 
            // txt_ProgrammeFrameLocate
            // 
            this.txt_ProgrammeFrameLocate.Location = new System.Drawing.Point(159, 75);
            this.txt_ProgrammeFrameLocate.Name = "txt_ProgrammeFrameLocate";
            this.txt_ProgrammeFrameLocate.Size = new System.Drawing.Size(466, 21);
            this.txt_ProgrammeFrameLocate.TabIndex = 7;
            this.txt_ProgrammeFrameLocate.TextChanged += new System.EventHandler(this.Txt_Select_SettingLocate_TextChanged);
            // 
            // lbl_Select_GitInstallDir
            // 
            this.lbl_Select_GitInstallDir.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Select_GitInstallDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Select_GitInstallDir.Location = new System.Drawing.Point(633, 115);
            this.lbl_Select_GitInstallDir.Name = "lbl_Select_GitInstallDir";
            this.lbl_Select_GitInstallDir.Size = new System.Drawing.Size(25, 21);
            this.lbl_Select_GitInstallDir.TabIndex = 10;
            this.lbl_Select_GitInstallDir.Tag = this.txt_GitInstallDir;
            this.lbl_Select_GitInstallDir.Text = "...";
            this.lbl_Select_GitInstallDir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Select_GitInstallDir.Click += new System.EventHandler(this.Lbl_Select_SettingLocate_Click);
            // 
            // txt_GitInstallDir
            // 
            this.txt_GitInstallDir.Location = new System.Drawing.Point(159, 115);
            this.txt_GitInstallDir.Name = "txt_GitInstallDir";
            this.txt_GitInstallDir.Size = new System.Drawing.Size(466, 21);
            this.txt_GitInstallDir.TabIndex = 6;
            this.txt_GitInstallDir.TextChanged += new System.EventHandler(this.Txt_Select_SettingLocate_TextChanged);
            // 
            // lbl_Select_VSInstallDir
            // 
            this.lbl_Select_VSInstallDir.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Select_VSInstallDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Select_VSInstallDir.Location = new System.Drawing.Point(633, 154);
            this.lbl_Select_VSInstallDir.Name = "lbl_Select_VSInstallDir";
            this.lbl_Select_VSInstallDir.Size = new System.Drawing.Size(25, 21);
            this.lbl_Select_VSInstallDir.TabIndex = 9;
            this.lbl_Select_VSInstallDir.Tag = this.txt_VSInstallDir;
            this.lbl_Select_VSInstallDir.Text = "...";
            this.lbl_Select_VSInstallDir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Select_VSInstallDir.Click += new System.EventHandler(this.Lbl_Select_SettingLocate_Click);
            // 
            // txt_VSInstallDir
            // 
            this.txt_VSInstallDir.Location = new System.Drawing.Point(159, 154);
            this.txt_VSInstallDir.Name = "txt_VSInstallDir";
            this.txt_VSInstallDir.Size = new System.Drawing.Size(466, 21);
            this.txt_VSInstallDir.TabIndex = 5;
            this.txt_VSInstallDir.TextChanged += new System.EventHandler(this.Txt_Select_SettingLocate_TextChanged);
            // 
            // btn_Back_BaseInfo_Setting
            // 
            this.btn_Back_BaseInfo_Setting.Location = new System.Drawing.Point(713, 415);
            this.btn_Back_BaseInfo_Setting.Name = "btn_Back_BaseInfo_Setting";
            this.btn_Back_BaseInfo_Setting.Size = new System.Drawing.Size(75, 23);
            this.btn_Back_BaseInfo_Setting.TabIndex = 8;
            this.btn_Back_BaseInfo_Setting.Text = "返回";
            this.btn_Back_BaseInfo_Setting.UseVisualStyleBackColor = true;
            this.btn_Back_BaseInfo_Setting.Click += new System.EventHandler(this.Btn_BackBaseInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "VS Studio安装目录：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "git安装目录：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "源程序默认存放位置：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "新项目默认选择位置：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Config_BaseInfo);
            this.Controls.Add(this.pnl_Config_AvailableUtils);
            this.Controls.Add(this.pnl_Setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "程序框架脚手架-基本信息";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_Config_BaseInfo.ResumeLayout(false);
            this.pnl_Config_BaseInfo.PerformLayout();
            this.pnl_InitialUI.ResumeLayout(false);
            this.pnl_InitialUI.PerformLayout();
            this.pnl_Config_AvailableUtils.ResumeLayout(false);
            this.pnl_Config_AvailableUtils.PerformLayout();
            this.flp_AvailableUtils.ResumeLayout(false);
            this.pnl_Setting.ResumeLayout(false);
            this.pnl_Setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProgrameName;
        private System.Windows.Forms.TextBox txt_ProgrammeName;
        private System.Windows.Forms.Label lbl_ProgrammeDir;
        private System.Windows.Forms.TextBox txt_ProgrammeDir;
        private System.Windows.Forms.Label lbl_ProgrammeDirSelected;
        private System.Windows.Forms.Panel pnl_Config_BaseInfo;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK_BaseInfo;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.CheckBox cb_GitSelect;
        private System.Windows.Forms.Panel pnl_Config_AvailableUtils;
        private System.Windows.Forms.CheckBox cb_UtilsAll;
        private System.Windows.Forms.FlowLayoutPanel flp_AvailableUtils;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Back_BaseInfo;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel pnl_Setting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ProgrammeFrameLocate;
        private System.Windows.Forms.TextBox txt_GitInstallDir;
        private System.Windows.Forms.TextBox txt_VSInstallDir;
        private System.Windows.Forms.TextBox txt_ProjectLocate;
        private System.Windows.Forms.Button btn_Back_BaseInfo_Setting;
        private System.Windows.Forms.Label lbl_Select_ProjectLocate;
        private System.Windows.Forms.Label lbl_Select_ProgrammeFrameLocate;
        private System.Windows.Forms.Label lbl_Select_GitInstallDir;
        private System.Windows.Forms.Label lbl_Select_VSInstallDir;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Panel pnl_InitialUI;
        private System.Windows.Forms.Label lbl_Tip_ResourcesDir;
        private System.Windows.Forms.Label lbl_Tip_UIInitialCode;
        private System.Windows.Forms.Label lbl_ResourcesDirSelected;
        private System.Windows.Forms.TextBox txt_ResourcesDir;
        private System.Windows.Forms.Label lbl_ResourcesDir;
        private System.Windows.Forms.Label lbl_UIInitialCodeSelected;
        private System.Windows.Forms.TextBox txt_UIInitialCodeLocate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_InitialUI;
        private System.Windows.Forms.Label lbl_Tip_NameSpaceName;
        private System.Windows.Forms.Label lbl_Tip_ClassName;
        private System.Windows.Forms.TextBox txt_ClassName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_NameSpaceName;
        private System.Windows.Forms.Label label7;
    }
}

