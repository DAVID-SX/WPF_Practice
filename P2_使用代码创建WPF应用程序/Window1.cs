// 【01】添加创建WPF窗体所需的引用
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace P2_使用代码创建WPF应用程序
{
    // 【02】让该类继承于Window
    class Window1 : Window
    {
        // 定义按钮
        private Button button1;

        // 定义按钮单击的事件
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "Thank you.";
        }

        // 定义窗体的构造函数
        public Window1()
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
            button1 = new Button();
            button1.Content = "Please Click me.";
            button1.Margin = new Thickness(30);
            button1.Click += button1_Click;

            // 定义面板对象与按钮之间的关系
            IAddChild container = panel;
            container.AddChild(button1);

            container = this;
            container.AddChild(panel);
        }
    }
}
