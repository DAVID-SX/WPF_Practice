using System;
// Application类的命名空间
using System.Windows;

namespace WpfApplicationClass
{

    class StartUp
    {
        //设置为单线程
        [STAThread()]
        //定义Main函数用来启动相关项目
        static void Main()
        {
            //实例化application类
            Application app = new Application();
            //实例化MainWindow窗体
            MainWindow mainWindow = new MainWindow();
            //利用application类的Run函数启动MainWindow
            app.Run(mainWindow);
            ///之后右击项目名称，在属性→应用程序→启动对象中将
            ///项目的启动项设置给该类（StartUp类），默认的启动对象
            ///为app.xaml文档;也可是不更改项目的启动项，直接在app.xmal文档中更改
            ///StartupUri的值，StartupUri用来确定代表主窗口的xaml文档
        }
    }
}
