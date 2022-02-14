using Microsoft.WindowsAPICodePack.Dialogs;
using ProgrammeFrameCLI.Common;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProgrammeFrameCLI
{
    public partial class MainForm : Form
    {
        #region 基本信息页
        /// <summary>
        /// 设置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Setting_Click(object sender, EventArgs e)
        {
            PanelVisibleControl(false, false, true);
            txt_ProjectLocate.Text = Properties.Settings.Default.ProjectLocate;
            txt_ProgrammeFrameLocate.Text = Properties.Settings.Default.ProgrammeFrameLocate;
            txt_GitInstallDir.Text = Properties.Settings.Default.GitInstallDir;
            txt_VSInstallDir.Text = Properties.Settings.Default.VSInstallDir;
        }

        /// <summary>
        /// 项目存放路径选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbl_ProgrammeDirSelected_Click(object sender, EventArgs e)
        {
            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_ProgrammeDir.Text = commonOpenFileDialog.FileName;
            }
        }

        /// <summary>
        /// 项目存放路径合法性判断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_ProgrammeDirInfo_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_ProgrammeName.Text, @"^[^/:*?<>\""|\\]+$") && Regex.IsMatch(txt_ProgrammeDir.Text, @"^[a-zA-Z]:(((\\(?! )[^/:*?<>\""|\\]+)+\\?)|(\\)?)\s*$"))
                btn_OK_BaseInfo.Enabled = true;
            else
                btn_OK_BaseInfo.Enabled = false;
        }

        /// <summary>
        /// 取消按钮（退出程序）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(projectDir)) Directory.Delete(projectDir, true);
            Application.Exit();
        }

        /// <summary>
        /// 下一步按钮（进入工具选择页面）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OK_BaseInfo_Click(object sender, EventArgs e)
        {
            try
            {
                //针对基础信息页点了下一步又返回来修改基础信息后在点下一步的情况，删除上次创建的目录
                if (!string.IsNullOrEmpty(projectDir) && !projectDir.Equals((txt_ProgrammeDir.Text + "\\" + txt_ProgrammeName.Text).Replace("\\\\", "\\"))) Directory.Delete(projectDir, true);

                if (txt_ProgrammeDir.Text.EndsWith("\\")) projectDir = txt_ProgrammeDir.Text + txt_ProgrammeName.Text;
                else projectDir = txt_ProgrammeDir.Text + "\\" + txt_ProgrammeName.Text;

                Directory.CreateDirectory(projectDir);
                GlobalData.logger.Info("创建项目路径：" + projectDir);

                Utils.Utils.DirectoryCopy(Properties.Settings.Default.ProgrammeFrameLocate, projectDir, new string[] { ".git", ".vs", "Debug", "Release", "obj" }, new string[] { "LICENSE", "ProgrammeFrame.csproj.user", "README.md" });

                ChangeProjectName(projectDir, txt_ProgrammeName.Text);

                ChangeFileContext(projectDir, txt_ProgrammeName.Text);

                if (cb_GitSelect.Checked)
                    Utils.Utils.CMDExecute("start \"\" /MIN \"" + Properties.Settings.Default.GitInstallDir + "\\bin\\sh.exe\" -c \"cd " + projectDir.Replace('\\', '/') + "; git init\"");

                PanelVisibleControl(false, true, false);

                flp_AvailableUtils.Controls.Clear();
                DisplayAvailableUtils(projectDir + @"\Utils");
            }
            catch (Exception ex)
            {
                GlobalData.logger.Error("Btn_OK_Click", ex);
            }
        }
        #endregion

        #region 可选功能页
        /// <summary>
        /// 返回按钮（返回基本信息页面）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Back_BaseInfo_Click(object sender, EventArgs e)
        {
            PanelVisibleControl(true, false, false);
        }

        /// <summary>
        /// 确定按钮（完成项目搭建）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            //如果没有全选的话就删掉没选中的类文件，不使用cb_UtilsAll是因为还有个TODO逻辑待处理
            if(listSelectedUtils.Count != utilsCount)
            {
                foreach(string file in Directory.GetFiles(projectDir + "\\Utils"))
                {
                    if(!listSelectedUtils.Select(util => util.ClassFullPath).Contains(file) && !file.Contains("Utils.cs"))
                    {
                        File.Delete(file);
                    }
                }

                StreamReader sr = new StreamReader(projectDir + "\\" + Utils.Utils.FindFileNameInPath(projectDir) + ".csproj");
                StringBuilder sb = new StringBuilder();
                while(!sr.EndOfStream)
                {
                    string content = sr.ReadLine();
                    if (content.Contains("Utils") && !content.Contains("Utils.cs"))
                    {
                        foreach(string name in listSelectedUtils.Select(util => util.Name))
                        {
                            //通过这种方式删掉文件里没被选中的类
                            if (content.Contains(name))
                            {
                                sb.AppendLine(content);
                                break;
                            }
                        }
                    }
                    else
                        sb.AppendLine(content);
                }
                sr.Close();
                StreamWriter sw = new StreamWriter(projectDir + "\\" + Utils.Utils.FindFileNameInPath(projectDir) + ".csproj");
                sw.WriteLine(sb);
                sw.Close();
            }

            System.Diagnostics.Process.Start(Properties.Settings.Default.VSInstallDir + @"\Common7\IDE\devenv.exe", projectDir + "\\" + txt_ProgrammeName.Text + ".csproj");

            Application.Exit();
        }

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cb_UtilsAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in flp_AvailableUtils.Controls) checkBox.Checked = (sender as CheckBox).Checked;
        }
        #endregion

        #region 设置页
        /// <summary>
        /// 选择各种程序位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbl_Select_SettingLocate_Click(object sender, EventArgs e)
        {
            try
            {
                if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    if(MessageBox.Show("确认修改？","提示",MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        ((sender as Label).Tag as TextBox).Text = commonOpenFileDialog.FileName;
                        Properties.Settings.Default.GetType().GetProperty(((sender as Label).Tag as TextBox).Name.Replace("txt_", "")).SetValue(Properties.Settings.Default, commonOpenFileDialog.FileName);
                        Properties.Settings.Default.Save();

                        if ((sender as Label).Name.Equals("lbl_Select_ProjectLocate")) commonOpenFileDialog.InitialDirectory = Properties.Settings.Default.ProjectLocate;
                        if ((sender as Label).Name.Equals("lbl_Select_GitInstallDir"))
                        {
                            if (File.Exists(Properties.Settings.Default.GitInstallDir + "\\bin\\sh.exe"))
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
            }
            catch (Exception ex)
            {
                GlobalData.logger.Error(MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        private void Txt_Select_SettingLocate_TextChanged(object sender, EventArgs e)
        {
            //本来是想验证目录输入不符合格式的话不允许返回，然而git目录就不是标准格式，所以算了...
        }

        /// <summary>
        /// 设置界面返回（确定）按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_BackBaseInfo_Click(object sender, EventArgs e)
        {
            PanelVisibleControl(true, false, false);
        }
        #endregion
    }
}
