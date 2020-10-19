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
using System.Windows.Shapes;
using System.IO;

namespace UI
{
    /// <summary>
    /// Lógica interna para CadProd.xaml
    /// </summary>
    public partial class CadProd : Window
    {

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public CadProd()
        {
            InitializeComponent();
        }

        private void BtnBrowserImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();

            dialog.Filter = "PNG | *.png | JPEG | *.jpg | BMP | *.bmp";

            if(dialog.ShowDialog() == true)
            {

            }
        }

        private void BtnSair_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
