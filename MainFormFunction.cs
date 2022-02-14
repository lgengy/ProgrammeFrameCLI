using ProgrammeFrameCLI.Common;
using ProgrammeFrameCLI.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ProgrammeFrameCLI
{
    public partial class MainForm : Form
    {
        private List<EntityAvailableUtil> listSelectedUtils = new List<EntityAvailableUtil>();
        private int utilsCount = 0;

        /// <summary>
        /// 项目文件名中包含ProgrammeFrame的替换为指定名称
        /// </summary>
        /// <param name="projectDir">项目位置</param>
        /// <param name="text">指定名称</param>
        private void ChangeProjectName(string projectDir, string text)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(projectDir);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();
                foreach(FileSystemInfo item in fileinfo)
                {
                    if (item is DirectoryInfo)
                        ChangeProjectName(item.FullName, text);
                    else
                    {
                        if (item.Name.Contains("ProgrammeFrame"))
                            File.Move(item.FullName, item.FullName.Replace("ProgrammeFrame", text));
                    }
                }
            }
            catch (Exception ex)
            {
                GlobalData.logger.Error(MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        /// <summary>
        /// 文件内容包含ProgrammeFrame的改为指定内容
        /// </summary>
        /// <param name="projectDir">项目位置</param>
        /// <param name="text">指定内容</param>
        private void ChangeFileContext(string projectDir, string text, string[] validSuffix = null)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(projectDir);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();
                foreach (FileSystemInfo item in fileinfo)
                {
                    if (item is DirectoryInfo)
                        ChangeFileContext(item.FullName, text, validSuffix);
                    else
                    {
                        if(validSuffix == null || (validSuffix != null && validSuffix.Contains(item.Extension)))
                        {
                            StringBuilder sb = new StringBuilder();
                            StreamReader sr = new StreamReader(item.FullName);
                            bool haveKeyWord = false;
                            while (!sr.EndOfStream)
                            {
                                string temp = sr.ReadLine();
                                if (!haveKeyWord && temp.Contains("ProgrammeFrame")) haveKeyWord = true;
                                sb.AppendLine(temp);
                            }
                            sr.Close();

                            if (haveKeyWord)
                            {
                                sb.Replace("ProgrammeFrame", text);
                                StreamWriter sw = new StreamWriter(item.FullName);
                                sw.WriteLine(sb);
                                sw.Close();
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

        /// <summary>
        /// 显示指定目录下所有可用的工具函数
        /// </summary>
        /// <param name="dir">目录</param>
        private void DisplayAvailableUtils(string dir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(dir);
            FileSystemInfo[] fileinfo = directoryInfo.GetFileSystemInfos();
            foreach (FileSystemInfo item in fileinfo)
            {
                if (item is DirectoryInfo) DisplayAvailableUtils(item.FullName);
                else
                {
                    EntityAvailableUtil availableUtil = new EntityAvailableUtil();
                    if (!item.Name.Equals("Utils.cs"))
                    {
                        utilsCount++;
                        StreamReader sr = new StreamReader(item.FullName);
                        while (!sr.EndOfStream)
                        {
                            string[] content = sr.ReadLine().Split('：');
                            if (content.Length > 1)
                            {
                                availableUtil.ClassFullPath = item.FullName;
                                if (content[0].Contains("类  名")) availableUtil.Name = content[1];
                                if (content[0].Contains("详  情")) availableUtil.Detail = content[1];
                                if (content[0].Contains("描  述"))
                                {
                                    availableUtil.Description = content[1];
                                    CheckBox cb = new CheckBox
                                    {
                                        AutoSize = false,
                                        Size = new Size(110, 140),
                                        BackColor = Color.SkyBlue,
                                        BackgroundImage = Properties.Resources.availableUtils,
                                        BackgroundImageLayout = ImageLayout.Stretch,
                                        CheckAlign = ContentAlignment.BottomLeft,
                                        Margin = new Padding(8, 12, 8, 8),
                                        FlatStyle = FlatStyle.Popup,
                                        Text = content[1],
                                        TextAlign = ContentAlignment.BottomCenter,
                                        Tag = availableUtil
                                    };
                                    cb.CheckedChanged += Cb_CheckedChanged;
                                    flp_AvailableUtils.Controls.Add(cb);
                                }
                            }
                            else if (content[0].EndsWith("***/")) break;
                        }
                        sr.Close();
                    }
                }
            }
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            EntityAvailableUtil availableUtil = cb.Tag as EntityAvailableUtil;

            if (cb.Checked)
            {
                cb.BackColor = Color.SteelBlue;
                if(!listSelectedUtils.Contains(availableUtil)) listSelectedUtils.Add(availableUtil);
                if (listSelectedUtils.Count == utilsCount && !cb_UtilsAll.Checked) cb_UtilsAll.Checked = true;
            }
            else
            {
                cb.BackColor = Color.SkyBlue;
                if (listSelectedUtils.Contains(availableUtil)) listSelectedUtils.Remove(availableUtil);
                //if (listSelectedUtils.Count != utilsCount && cb_UtilsAll.Checked) cb_UtilsAll.Checked = false;//TODO 还没想好怎么处理全选状态下取消某项选择后怎么处理全选复选框选中状态
            }
        }

        /// <summary>
        /// 面板显隐控制
        /// </summary>
        /// <param name="pnl1">基本信息面板</param>
        /// <param name="pnl2">工具选择面板</param>
        /// <param name="pnl3">设置面板</param>
        private void PanelVisibleControl(bool pnl1, bool pnl2, bool pnl3)
        {
            pnl_Config_BaseInfo.Visible = pnl1;
            pnl_Config_AvailableUtils.Visible = pnl2;
            pnl_Setting.Visible = pnl3;

            if(pnl1) Text = "程序框架脚手架-基本信息";
            else if(pnl2) Text = "程序框架脚手架-工具选择";
            else if (pnl3) Text = "程序框架脚手架-设置";
        }
    }
}
