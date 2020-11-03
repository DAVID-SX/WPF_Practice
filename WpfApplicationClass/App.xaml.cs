using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplicationClass
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            //理论上在添加完命令行参数后StartupEventArgs参数的args值就不会为空
            if (e.Args.Length > 0)
            {
                string file = e.Args[0];
                if (File.Exists(file))
                {
                    window.LoadFile(file);
                }
            }
            window.Show(); 
        }
    }
}
