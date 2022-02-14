/********************************************************************
*
* 类  名：MainForm
*
* 作  者：lgengy
*
* 描  述：主界面函数。
* 
* 待  办：1、把数据库模块加到框架中，但是不进行追踪;
*
********************************************************************/

using Microsoft.WindowsAPICodePack.Dialogs;
using ProgrammeFrameCLI.Common;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ProgrammeFrameCLI
{
    public partial class MainForm : Form
    {
        string projectDir;
        CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GlobalData.logger.Info("==============================程序启动==============================");
            GlobalData.logger.Info("==========================版本号：1.0.0.1===========================");
            GlobalData.logger.Info("====================================================================");

            commonOpenFileDialog.IsFolderPicker = true;
            commonOpenFileDialog.Title = "请选择项目位置";
            commonOpenFileDialog.InitialDirectory = Properties.Settings.Default.ProjectLocate;

            //程序首次启动时进入设置界面进行配置
            if (!Properties.Settings.Default.UUID.Equals(Utils.Utils.GetSystemUUId()))
            {
                Properties.Settings.Default.UUID = Utils.Utils.GetSystemUUId();
                Properties.Settings.Default.Save();

                txt_ProjectLocate.Text = Properties.Settings.Default.ProjectLocate;
                txt_ProgrammeFrameLocate.Text = Properties.Settings.Default.ProgrammeFrameLocate;
                txt_GitInstallDir.Text = Properties.Settings.Default.GitInstallDir;
                txt_VSInstallDir.Text = Properties.Settings.Default.VSInstallDir;
                PanelVisibleControl(false, false, true);
            }

            if (System.IO.File.Exists(Properties.Settings.Default.GitInstallDir + "\\bin\\sh.exe"))
            {
                cb_GitSelect.Checked = true;
                cb_GitSelect.Enabled = true;
            }
            else
            {
                cb_GitSelect.Checked = false;
                cb_GitSelect.Enabled = false;
            }
        }
    }
}
