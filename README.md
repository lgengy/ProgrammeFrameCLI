# ProgrammeFrameCLI
配合ToolFunction仓库使用的WinForm程序开发环境一键搭建
## 开发环境
- Visual Studio 2019
## 使用说明
1. 克隆程序编译并运行，在bin\Release目录下得到可执行程序ProgrammeFrameCLI.exe；
2. 双击ProgrammeFrameCLI.exe，程序首次运行进入设置界面，请配置：
- 新项目默认选择位置，即新建项目的默认存放目录
- 源程序默认存放位置，即框架ProgrammeFrame（ToolFunction仓库）本地存放位置
- git安装目录，用于在创建项目时同步新建git仓库，有的话就填，没有的话就不用管
- VS Studio安装目录，项目完成后自动打开VS Studio
3. 配置完成后点击返回进入基本信息界面，后期亦可点击右上角齿轮进入设置界面重写配置；
4. 基本信息界面填写项目名称和位置，点击下一步进入工具选择界面；
5. 工具选择界面显示框架中提供的工具类，可根据程序要求自行配置，选定之后点击确定完成开发环境搭建。Utils作为框架核心工具必选，不可取消。
