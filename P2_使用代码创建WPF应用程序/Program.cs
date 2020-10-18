using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 添加所需的引用
using System.Windows;

namespace P2_使用代码创建WPF应用程序
{
    // 使该类继承于Application
    class Program : Application
    {
        // 使用单线程
        [STAThread()]

        // 定义主方法
        static void Main()
        {
            Program app = new Program();
            app.MainWindow = new Window1();  // 
            app.MainWindow.ShowDialog();     // 以模态的方式打开
        }
    }
}
