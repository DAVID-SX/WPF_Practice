using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace P21_SingleInstance
{
    class WpfApp:Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            showWindow();
        }


        public void showWindow()
        {
            MainWindow win = new MainWindow();
            win.Show();
        }
    }
}
