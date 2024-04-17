using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace WPF_09
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetUpSize(object sender, RoutedEventArgs e)
        {
            if (LabelMain.FontSize == 14) return;
            else LabelMain.FontSize += 2;
        }

        public void SetDownSize(object sender, RoutedEventArgs e)
        {
            if (LabelMain.FontSize == 6) return;
            else LabelMain.FontSize -= 2;
        }

        public void SetItalic(object sender, RoutedEventArgs e) 
        {
            if (LabelMain.FontStyle == FontStyles.Normal)
            {
                LabelMain.FontStyle = FontStyles.Italic;
                ButtonItalic.Content = "Прямой";
            }
            else
            {
                LabelMain.FontStyle = FontStyles.Normal;
                ButtonItalic.Content = "Наклон";
            }
        }

        public void SetVisibility(object sender, RoutedEventArgs e) 
        {
            if (LabelMain.Visibility == Visibility.Visible)
            {
                LabelMain.Visibility = Visibility.Collapsed;
                ButtonVisibily.Content = "Показать Label";
            }
            else 
            { 
                LabelMain.Visibility = Visibility.Visible;
                ButtonVisibily.Content = "Скрыть Label";
            }
        }

        public void GetOpenSlider(object sender, RoutedEventArgs e) 
        { 
            AlterWindow slider = new AlterWindow();
            slider.Show();
            Window.Close();
        }

        public void ShowClose(object sender, RoutedEventArgs e) => Close();
    }
}
