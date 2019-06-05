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

namespace WPF_TEST
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // タイトルバーと境界線を表示しない
            //this.WindowStyle = WindowStyle.None;

            // 最大化表示
            this.WindowState = WindowState.Maximized;

            UserComboBox.Items.Add("USER A");
            UserComboBox.Items.Add("USER B");
            UserComboBox.Items.Add("USER C");

            
        }

        
    }
}
