using System;
using System.Collections.Generic;
using System.Data;
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

namespace semana3_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        ClsDatos obj = new ClsDatos();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnConsultar_Click(object sender, RoutedEventArgs e)
        {
            GridAnios.ItemsSource = obj.ListaAnioPedidos(Convert.ToDateTime(txtAniosPedido.Text)).DefaultView;
        }

        private void DgvPedido_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int idPedido;
            var item = GridMeses.SelectedItem as DataRowView;
            if (null == item) return;
            idPedido = Convert.ToInt32(item.Row["IdPedido"]);
            GridEmpleados.ItemsSource = obj.ListaDetalle(idPedido).DefaultView;
            txtMontoTotal.Text = Convert.ToString(obj.PedidoTotal(idPedido));
        }
    }
}
