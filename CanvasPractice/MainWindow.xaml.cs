using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CanvasPractice
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void combox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.inkCanvas.EditingMode = (InkCanvasEditingMode)(combox.SelectedItem);
        }

        private void inkCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode)))
            {
                this.combox.Items.Add(mode);
            }
            this.combox.SelectedIndex = 0;
        }
    }
}
