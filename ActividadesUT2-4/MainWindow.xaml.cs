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

namespace ActividadesUT2_4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtbEscrito_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtLimite.Content = txtbEscrito.Text.Length + "/140";
            if(txtbEscrito.Text.Length == 140)
            {
                txtbEscrito.IsReadOnly = true;
            }
        }
    }
}
