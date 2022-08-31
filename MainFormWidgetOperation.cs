using Microsoft.WindowsAPICodePack.Dialogs;
using ProgrammeFrameCLI.Common;
using ProgrammeFrameCLI.Entity;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
        /// 项目存放路径/资源文件路径选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbl_ProgrammeDirSelected_Click(object sender, EventArgs e)
        {
            commonOpenFileDialog.IsFolderPicker = true;
            if ((sender as Label).Name.Contains("ProgrammeDirSelected")) commonOpenFileDialog.Title = "请选择项目保存位置";
            else
            {
                commonOpenFileDialog.InitialDirectory = Path.GetDirectoryName(txt_UIInitialCodeLocate.Text);
                commonOpenFileDialog.Title = "请选择资源文件所在位置";
            }
            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                ((sender as Label).Tag as TextBox).Text = commonOpenFileDialog.FileName;
            }
        }

        /// <summary>
        /// 界面代码模板选择
        /// </summary>
        private void Lbl_UIInitialCodeSelected_Click(object sender, EventArgs e)
        {
            commonOpenFileDialog.IsFolderPicker = false;
            commonOpenFileDialog.Title = "请选择界面代码模板";
            if(commonOpenFileDialog.Filters.Count == 0) commonOpenFileDialog.Filters.Add(new CommonFileDialogFilter("界面模板", "*.Designer.cs"));
            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                txt_UIInitialCodeLocate.Text = commonOpenFileDialog.FileName;
            }
        }

        private void Cb_InitialUI_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked) pnl_InitialUI.Visible = true;
            else pnl_InitialUI.Visible = false;
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
                projectName = txt_ProgrammeName.Text.Trim();

                //针对基础信息页点了下一步又返回来修改基础信息后在点下一步的情况，删除上次创建的目录
                if (!string.IsNullOrEmpty(projectDir) && !projectDir.Equals((txt_ProgrammeDir.Text + "\\" + projectName).Replace("\\\\", "\\"))) Directory.Delete(projectDir, true);

                if (txt_ProgrammeDir.Text.EndsWith("\\")) projectDir = txt_ProgrammeDir.Text + projectName;
                else projectDir = txt_ProgrammeDir.Text + "\\" + projectName;

                Directory.CreateDirectory(projectDir);
                GlobalData.logger.Info("创建项目路径：" + projectDir);

                if (cb_GitSelect.Checked)
                {
                    GlobalData.logger.Info("初始化git");
                    Utils.Utils.CMDExecute("start \"\" /MIN \"" + Properties.Settings.Default.GitInstallDir + "\\bin\\sh.exe\" -c \"cd " + projectDir.Replace('\\', '/') + "; git init\"");
                    if(File.Exists(Application.StartupPath + "\\.gitignore")) File.Copy(Application.StartupPath + "\\.gitignore", projectDir + "\\.gitignore", true);
                    else GlobalData.logger.Info(".gitignore文件不存在");
                }

                Task.Factory.StartNew(() =>
                {
                    Utils.Utils.DirectoryCopy(Properties.Settings.Default.ProgrammeFrameLocate, projectDir, new string[] { ".git", ".vs", "Debug", "Release", "obj", "Utils" }, new string[] { "LICENSE", "ProgrammeFrame.csproj.user", "README.md", ".gitignore" });

                    ChangeProjectName(projectDir, projectName);

                    ChangeFileContext(projectDir, projectName);
                }).ContinueWith(t =>
                {
                    if (t.Status == TaskStatus.RanToCompletion)
                    {
                        if (cb_InitialUI.Checked)
                        {
                            GlobalData.logger.Info("初始化界面，模板路径：" + txt_UIInitialCodeLocate.Text);
                            GenerateUIFromExistUI(txt_UIInitialCodeLocate.Text.Trim(), projectDir + "\\MainForm.Designer.cs", txt_NameSpaceName.Text.Trim(), projectName, txt_ClassName.Text.Trim());
                            CopyResourcesFile(txt_ResourcesDir.Text.Trim(), projectDir);
                        }
                    }
                    else if(t.Exception != null)
                    {
                        GlobalData.logger.Error(t.Exception);
                    }
                });
                
                PanelVisibleControl(false, true, false);

                flp_AvailableUtils.Controls.Clear();
                DisplayAvailableUtils(Properties.Settings.Default.ProgrammeFrameLocate + @"\Utils");
            }
            catch (Exception ex)
            {
                GlobalData.logger.Error(ex);
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
            try
            {
                StreamReader sr = new StreamReader(projectDir + "\\" + Utils.Utils.FindFileNameInPath(projectDir) + ".csproj");
                StringBuilder sb = new StringBuilder();

                if (!Directory.Exists(projectDir + "\\Utils")) Directory.CreateDirectory(projectDir + "\\Utils");

                //拷贝工具类到新项目
                foreach (EntityAvailableUtil util in listSelectedUtils)
                {
                    File.Copy(util.ClassFullPath, projectDir + "\\Utils\\" + Path.GetFileName(util.ClassFullPath), true);
                }

                ChangeFileContext(projectDir + "\\Utils\\", projectName);

                //删除新项目csproj文件中没有的工具类
                while (!sr.EndOfStream)
                {
                    string content = sr.ReadLine();
                    if (content.Contains("Utils"))
                    {
                        if (listSelectedUtils.Where(util => content.Contains(util.Name + ".cs")).Count() > 0)
                            sb.AppendLine(content);
                    }
                    else
                        sb.AppendLine(content);
                }
                sr.Close();
                StreamWriter sw = new StreamWriter(projectDir + "\\" + Utils.Utils.FindFileNameInPath(projectDir) + ".csproj");
                sw.WriteLine(sb);
                sw.Close();

                System.Diagnostics.Process.Start(Properties.Settings.Default.VSInstallDir + @"\Common7\IDE\devenv.exe", projectDir + "\\" + txt_ProgrammeName.Text + ".csproj");

                Application.Exit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                GlobalData.logger.Error(ex);
            }
        }

        /// <summary>
        /// 全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cb_UtilsAll_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                foreach (CheckBox checkBox in flp_AvailableUtils.Controls) if (checkBox.Enabled) checkBox.Checked = true;
            }
            else
            {
                int checkedCount = 0;
                foreach (CheckBox checkBox in flp_AvailableUtils.Controls) if (checkBox.Checked) checkedCount++;
                if(checkedCount == flp_AvailableUtils.Controls.Count)
                    foreach (CheckBox checkBox in flp_AvailableUtils.Controls) 
                        if (checkBox.Enabled) checkBox.Checked = false;
            }
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
