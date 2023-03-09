using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using NBarCodes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;

namespace Gases.Logica
{
    public class Metodos

    {
        //CREDENCIALES PARA CONEXION CON EL WEB SERVICE Y VARIBLE PARA GUARDAR INFORMACION DE DATOS CONVERTIDOS EN JSON
        string user = "GRCEOPORTALV";
        string pass = "UfTgN-kE2a566&/";
        public string json;
        public static dynamic informacion; 

        public void ConsultarDatos(string contrato) //VARIABLE CONTRATO LEIDA DESDE LA VENTANA PRINCIPAL
        {

            //DEFINICION DE LOS METODOS DEL WEBSERVICE
            ServicioSGAS.DT_EstadoCuenta_req consulta = new ServicioSGAS.DT_EstadoCuenta_req();
            ServicioSGAS.DT_EstadoCuenta_res respuesta = new ServicioSGAS.DT_EstadoCuenta_res();
            ServicioSGAS.EstCuenta_OutClient salida = new ServicioSGAS.EstCuenta_OutClient();



            //CONSULTA DEL ATRIBUTO CONTRATO , HACIENDO USO DE DE VARAIBLE CONTRATO 
            consulta.contrato = contrato;
            //USO DE LAS CREDENCIALES DEL WEB SERVICE
            salida.ClientCredentials.UserName.UserName = user;
            salida.ClientCredentials.UserName.Password = pass;
            respuesta = salida.EstCuenta_Sync(consulta); //RESPUESTA DEL CONTRATO DIGITADO



            string cod = JsonConvert.SerializeObject(respuesta); //CONVERSION DE DATOS A FORMATO JSON
            cod = cod.Replace("{\"OclFactData\":\"", string.Empty); //ELIMINACION DE INFORMACION NO UTIL
            cod = cod.Replace("\\n\",\"OnuErrorcode\":\"0\",\"osbErrorMessage\":\"Operacion Exitosa\"}", string.Empty); //ELIMINACION DE SALTOS DE LINEA
            cod = cod.Replace("\\n", string.Empty);//ELIMINACION DE INFORMACION NO UTIL
            XmlDocument xmlDocument = new XmlDocument(); //CREACION DE ARCHIVO XML
            xmlDocument.LoadXml(cod);//CARGA DE DATOS AL ARCHIVO XML
            json = JsonConvert.SerializeXmlNode(xmlDocument);//CREACION DEL JSON
            informacion = JsonConvert.DeserializeObject(json);
            //MessageBox.Show((string)informacion.FORMATO.FR_ENCABEZADO.FACTURA.FACTCODI);



        }


        public void LlenarfuentesPDF(Fuentes fuente)
        {

            iText.Layout.Element.Paragraph PF = new iText.Layout.Element.Paragraph(fuente.Texto);
            PF.SetFixedPosition(fuente.Posx, fuente.Posy, fuente.Ancho);
            PF.SetFontSize(fuente.Tamaño);

            PF.SetFontColor(fuente.color);
            PF.SetFont(fuente.Funt);
            PF.SetTextAlignment(fuente.Alineamiento);
            PF.SetBold();
            document.Add(PF);

        }



        Document document;
        public static float Posx = 61;
        public static List<Fuentes> ListaPre = new List<Fuentes>();
       
        public void CargarPreterminadosEnPDF()
        {

            PdfDocument pdfDoc = new PdfDocument(new PdfReader(System.AppDomain.CurrentDomain.BaseDirectory + @"util\arte.pdf"), new PdfWriter(System.AppDomain.CurrentDomain.BaseDirectory + @"util\arte2.pdf"));

            document = new Document(pdfDoc);
            Preterminado.CargarCampos();
            Preterminado.CamposVariables();
            foreach (var campo in Preterminado.ListaPre)
            {


                LlenarfuentesPDF(campo);

            }
            foreach (var campo in Preterminado.ListaCampos)
            {


                LlenarfuentesPDF(campo);

            }

           //  GenerarCodigoBc();
           // PintarBc();
            pdfDoc.Close();
        }



        public void GenerarCodigoBc()
        {
            var settings = new BarCodeSettings
            {
                Type = BarCodeType.Code128,
                Data = "(416)7709998021396(8020)0074469156(3900)0000020600(96)20230117",
                WideWidth = 10,

            };

            var generator = new BarCodeGenerator(settings);

            using (var barcodeImage = generator.GenerateImage())
            {
                barcodeImage.Save(System.AppDomain.CurrentDomain.BaseDirectory + @"util\barcode.jpg");


            }
        }
       
        public void PintarBc()
        {
   
            iText.IO.Image.ImageData img = ImageDataFactory.Create(System.AppDomain.CurrentDomain.BaseDirectory + @"util\barcode.jpg");
            iText.Layout.Element.Image ImgBarcode = new iText.Layout.Element.Image(img);

            ImgBarcode.SetFixedPosition(100, 15);
            ImgBarcode.SetWidth(350);
            ImgBarcode.SetHeight(50);
            

            document.Add(ImgBarcode);

            

        }
    }

    


}