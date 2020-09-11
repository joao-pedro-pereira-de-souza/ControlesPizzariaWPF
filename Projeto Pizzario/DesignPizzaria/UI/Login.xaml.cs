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

using System.Threading;

namespace UI
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Login: Window
    {
        Thread tr;
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogar_MouseEnter(object sender, MouseEventArgs e)
        {
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#E7892E");

            btnLogar.Background = brush;

        }

        private void BtnLogar_MouseLeave(object sender, MouseEventArgs e)
        {
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF9F43");

            btnLogar.Background = brush;
        }

       
        private void BtnCadastrar_MouseEnter(object sender, MouseEventArgs e)
        {
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FF9F43");

            btnCadastrar.Background = brush;

            txbcad.Foreground = Brushes.White;
            btnCadastrar.BorderThickness = new Thickness(0, 0, 0, 0);
        }

        private void BtnCadastrar_MouseLeave(object sender, MouseEventArgs e)
        {
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#E7892E");

            btnCadastrar.Background = Brushes.White;

            txbcad.Foreground = brush;
            btnCadastrar.BorderThickness = new Thickness(1, 1, 1, 1);
        }

        private void BtnCadastrar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void BtnSair_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void BtnLogar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // fonte : https://www.youtube.com/watch?v=STKS803c-3c.
            Home home = new Home();
            home.Owner = this;

            this.Hide();

            home.ShowDialog();
         

        }

       

        private void PnlTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void LblEscSenha_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("tela recuperar senha \n em desenvolvimento");
        }
    }
}
