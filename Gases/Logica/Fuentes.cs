using iText.Kernel.Colors;
using iText.Kernel.Font;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gases.Logica
{
    //CLASE PARA GENERAR CARACTERISTICAS PROPIAS DE LOS CAMPOS
    public class Fuentes
    {
        public string Texto;
        public float Tamaño;
        public float Posx;
        public float Posy;                                                      // tipos de letra, tamaños y uso de posiciones
        public float Ancho;
        // public iText.Kernel.Colors.DeviceRgb color;
        public iText.Kernel.Colors.Color color = new DeviceRgb(0, 0, 0);
        public iText.Kernel.Font.PdfFont Funt = PdfFontFactory.CreateFont(@"C:\Windows\Fonts\calibri.ttf");
        public iText.Layout.Properties.TextAlignment Alineamiento = iText.Layout.Properties.TextAlignment.LEFT;
        public Boolean Negrita = false;




    }
}
