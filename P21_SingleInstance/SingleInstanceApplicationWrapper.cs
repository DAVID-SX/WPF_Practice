using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P21_SingleInstance
{
    //新建类，并使其继承自Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    class SingleInstanceApplicationWrapper:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        //定义构造函数
        public SingleInstanceApplicationWrapper()
        {
            this.IsSingleInstance = true; //设置为允许单实例模式
        }

        private WpfApp app;
        //重写受保护的OnStartup方法
        protected override bool OnStartup(StartupEventArgs eventArgs)
        {
            //return base.OnStartup(eventArgs);
            app = new WpfApp();  // 实例化wpfapp类
            app.Run();           // 调用类的Run方法
            return false;
        }

        //重写当打开下一个实例时的方法
        protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
        {
            base.OnStartupNextInstance(eventArgs);
            app.showWindow();  //此时并不会启动一个新的实例，而是使用showWindow方法打开一个窗口
        }
    }
}
