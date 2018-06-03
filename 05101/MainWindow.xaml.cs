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

namespace _05101
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生開啟檔案視窗
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 當按下開啟之後的反應
            if (result == true)
            {
                // 讀檔(路徑)
                TextArea.Text = System.IO.File.ReadAllText(dig.FileName);
            }
            
        }

        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveAsBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生儲存檔案視窗
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dig.ShowDialog();

            // 當按下儲存之後的反應
            if(result == true)
            {
                // 讀檔(路徑)
               System.IO.File.WriteAllText(dig.FileName, TextArea.Text);
            }
        }

        private void MiddleBtn_Click(object sender, RoutedEventArgs e)
        {
            // 改變字體大小
            TextArea.FontSize = 25;
        }

        private void BigBtn_Click(object sender, RoutedEventArgs e)
        {
            // 改變字體大小
            TextArea.FontSize = 35;
        }

        private void SmallBtn_Click(object sender, RoutedEventArgs e)
        {
            // 改變字體大小
            TextArea.FontSize = 15;
        }

        private void Gray_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void BackGray_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 改變背景與字體顏色
            TextArea.Background = Brushes.DimGray;
            TextArea.Foreground = Brushes.White;
        }

        private void BackWhite_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 改變背景與字體顏色
            TextArea.Background = Brushes.White;
            TextArea.Foreground = Brushes.Black;
        }
    }
}
