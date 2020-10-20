// 【01】添加创建WPF窗体所需的引用
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace P2_使用代码创建WPF应用程序
{
    // 【02】让该类继承于Window
    class Window2 : Window
    {
        // 定义名称列表
        readonly string[] name = { "zhangsan", "lisi", "wangwu" };
        readonly List<string> nameList = new List<string>(name);


        // 定义复选框
        private CheckBox checkBox;

        // 定义复选框被选中后的事件
        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            checkBox.Content = "Checked";
        }

        // 定义窗体的构造函数
        public Window2()
        {
            InitializeComponent();
        }

        // 定义窗口初识化函数
        public void InitializeComponent()
        {
            // 设置窗体
            this.Width = 285;
            this.Height = 250;
            this.Left = this.Top = 100;
            this.Title = "Code_Only Window";

            // 创建停靠面板对象
            DockPanel panel = new DockPanel();

            // 创建按钮对象
            checkBox = new CheckBox();
            checkBox.Content = "Please Click me.";
            checkBox.Margin = new Thickness(30);
            checkBox.Checked += checkBox_Checked;

            // 定义面板对象与按钮之间的关系
            IAddChild container = panel;
            container.AddChild(checkBox);

            container = this;
            container.AddChild(panel);
        }
    }
}
