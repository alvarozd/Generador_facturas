using Gases.Logica;
using iText.Kernel.Pdf;
using Newtonsoft.Json;
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
using System.Xml;

namespace Gases
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
       
        string contrato;

       

        Metodos metodo = new Metodos(); //CREACION DEL OBJETO METODO DE LA CLASE QUE CONTIENE LOS METODOS



        private void Button_Click(object sender, RoutedEventArgs e)
        {





            txtjson.Clear(); //LIMPIEZA DE TEXTBOX (PRUEBA)
            contrato = txtcontrato.Text; //LECTURA DEL NUMERO DE CONTRATO
            metodo.ConsultarDatos(contrato); //LLAMADO Y ENVIO DE VARIBLE CONTRATO
            txtjson.Text = metodo.json; //MUESTRA DEL RESULTADO DEL JSON TRAIDO DE LA CLASE "METODOS"

            //metodo.GenerarCodigoBc();
            metodo.CargarPreterminadosEnPDF();
           
         
            
            
           




        }
    }
}
