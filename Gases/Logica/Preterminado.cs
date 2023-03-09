
using Gases.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gases.Logica
{
    public class Preterminado
    {
        public static float Posx = 61;
        public static List<Fuentes> ListaPre = new List<Fuentes>();
        public static void CargarCampos()
        {
            Posx = 61;

            #region Informacion Cliente
            Fuentes Campos = new Fuentes
            {
                Texto = "Nombre",
                Tamaño = 7,
                Posx = Posx,
                Posy = 516,
                Ancho = 35,


            };
            ListaPre.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "Cédula",
                Tamaño = 7,
                Posx = Posx,
                Posy = 506,
                Ancho = 35,

            };
            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Dirección",
                Tamaño = 7,
                Posx = Posx,
                Posy = 496,
                Ancho = 35,

            };
            ListaPre.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "Municipio",
                Tamaño = 7,
                Posx = Posx,
                Posy = 486,
                Ancho = 35,

            };
            ListaPre.Add(Campos);
            #endregion

            #region Informacion Tecnica
            Posx = 28;
            Campos = new Fuentes
            {
                Texto = "Ruta Reparto",
                Tamaño = 6,
                Posx = Posx,
                Posy = 381,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT
            };
            ListaPre.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "Categoria",
                Tamaño = 6,
                Posx = Posx,
                Posy = 374,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT
            };
            ListaPre.Add(Campos);



            Campos = new Fuentes
            {
                Texto = "Nivel de tension",
                Tamaño = 6,
                Posx = Posx,
                Posy = 367,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT
            };
            ListaPre.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "Transformador",
                Tamaño = 6,
                Posx = Posx,
                Posy = 360,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT
            };
            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Alimentador",
                Tamaño = 6,
                Posx = Posx,
                Posy = 353,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT
            };
            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Ciclo",
                Tamaño = 6,
                Posx = Posx,
                Posy = 346,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT
            };
            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Estrato",
                Tamaño = 6,
                Posx = Posx,
                Posy = 339,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT
            };
            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Carga Instal. (KVA)\r\n",
                Tamaño = 6,
                Posx = Posx,
                Posy = 332,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT
            };
            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Grupo",
                Tamaño = 6,
                Posx = Posx,
                Posy = 325,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT
            };
            ListaPre.Add(Campos);
            #endregion

            #region Indicadores de Calidad
            Campos = new Fuentes
            {
                Texto = "HC:",
                Tamaño = 6,
                Posx = 185,                         //Indicadores de calidad
                Posy = 426,
                Ancho = 10,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "VC:",
                Tamaño = 6,
                Posx = 185,                         //Indicadores de calidad
                Posy = 413,
                Ancho = 10,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "CEC:",
                Tamaño = 6,
                Posx = 185,                         //Indicadores de calidad
                Posy = 400,
                Ancho = 12,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "DIU:",
                Tamaño = 6,
                Posx = 185,                         //Indicadores de calidad
                Posy = 387,
                Ancho = 12,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "DIUG:",
                Tamaño = 6,
                Posx = 185,                         //Indicadores de calidad
                Posy = 374,
                Ancho = 16,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "%t:",
                Tamaño = 6,
                Posx = 220,                         //Indicadores de calidad
                Posy = 426,
                Ancho = 14,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Dt:",
                Tamaño = 6,
                Posx = 220,                         //Indicadores de calidad
                Posy = 413,
                Ancho = 14,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "FIU:",
                Tamaño = 6,
                Posx = 220,                         //Indicadores de calidad
                Posy = 387,
                Ancho = 14,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "FIUG:",
                Tamaño = 6,
                Posx = 220,                         //Indicadores de calidad
                Posy = 374,
                Ancho = 14,


            };

            ListaPre.Add(Campos);
            #endregion

            #region Componentes Costos de prestacion de servicios
            Campos = new Fuentes
            {
                Texto = "CUv = Gm + Tm + Dn + Cv + PR + Rm CUf=0",
                Tamaño = 6,
                Posx = 30,                         //Componentes costos de prestacion de servicio
                Posy = 305,
                Ancho = 143,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER


            };

            ListaPre.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "Gm = ",
                Tamaño = 6,
                Posx = 35,                         //Componentes costos de prestacion de servicio
                Posy = 295,
                Ancho = 20,



            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Tm = ",
                Tamaño = 6,
                Posx = 35,                         //Componentes costos de prestacion de servicio
                Posy = 285,
                Ancho = 20,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "PR = ",
                Tamaño = 6,
                Posx = 80,                         //Componentes costos de prestacion de servicio
                Posy = 295,
                Ancho = 20,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Dn = ",
                Tamaño = 6,
                Posx = 80,                         //Componentes costos de prestacion de servicio
                Posy = 285,
                Ancho = 20,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Rm = ",
                Tamaño = 6,
                Posx = 140,                         //Componentes costos de prestacion de servicio
                Posy = 295,
                Ancho = 20,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Cv = ",
                Tamaño = 6,
                Posx = 140,                         //Componentes costos de prestacion de servicio
                Posy = 285,
                Ancho = 20,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Costo Unitario:",
                Tamaño = 6,
                Posx = 70,                         //Componentes costos de prestacion de servicio
                Posy = 280,
                Ancho = 50,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Tarifa Aplicada:",
                Tamaño = 6,
                Posx = 70,                         //Componentes costos de prestacion de servicio
                Posy = 270,
                Ancho = 50,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Cupo Total:",
                Tamaño = 6,
                Posx = 26,                         //Componentes costos de prestacion de servicio
                Posy = 210,
                Ancho = 40,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Cupo Utilizado:",
                Tamaño = 6,
                Posx = 26,                         //Componentes costos de prestacion de servicio
                Posy = 200,
                Ancho = 40,

            };

            ListaPre.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "Tasa:",
                Tamaño = 6,
                Posx = 26,                         //Componentes costos de prestacion de servicio
                Posy = 190,
                Ancho = 40,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Financiación:",
                Tamaño = 6,
                Posx = 26,                         //Componentes costos de prestacion de servicio
                Posy = 180,
                Ancho = 40,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Interes:",
                Tamaño = 6,
                Posx = 26,                         //Componentes costos de prestacion de servicio
                Posy = 170,
                Ancho = 40,

            };

            ListaPre.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "Seguro Deudor:",
                Tamaño = 6,
                Posx = 26,                         //Componentes costos de prestacion de servicio
                Posy = 160,
                Ancho = 40,

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "PRODUCTO:",
                Tamaño = 15,
                Posx = 35,                         //Componentes costos de prestacion de servicio
                Posy = 135,
                Ancho = 75,
                Negrita = true

            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Grandes Contribuyentes. Agentes retención de IVA.\r\nAutorrenedor renta Res.5001 08/07/2021",
                Tamaño = 6,
                Posx = 20,                         //Componentes costos de prestacion de servicio
                Posy = 116,
                Ancho = 150,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER

            };

            ListaPre.Add(Campos);
            #endregion

            #region Perodo de consumo
            Campos = new Fuentes
            {
                Texto = "Desde",
                Tamaño = 6,
                Posx = 408,                         //Mes
                Posy = 425,
                Ancho = 20,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Hasta",
                Tamaño = 6,
                Posx = 450,                         //Mes
                Posy = 425,
                Ancho = 20,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Pago Oportuno Hasta",
                Tamaño = 6,
                Posx = 400,                         //Mes
                Posy = 405,
                Ancho = 70,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Suspencion desde",
                Tamaño = 6,
                Posx = 400,                         //Mes
                Posy = 373,
                Ancho = 70,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT


            };

            ListaPre.Add(Campos);

            #endregion

            #region Estado de financiacion
            Campos = new Fuentes
            {
                Texto = "Fecha y ultimo pago",
                Tamaño = 6,
                Posx = 195,                         //Mes
                Posy = 150,
                Ancho = 50,


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Total a Pagar",
                Tamaño = 7,
                Posx = 324,                         //Mes
                Posy = 155,
                Ancho = 50,
                Negrita = true


            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Total conceptos energia",
                Tamaño = 6,
                Posx = 324,                         //Mes
                Posy = 200,
                Ancho = 70,



            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Total otros conceptos",
                Tamaño = 6,
                Posx = 324,                         //Mes
                Posy = 193,
                Ancho = 70,



            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Valor reclamo",
                Tamaño = 6,
                Posx = 324,                         //Mes
                Posy = 186,
                Ancho = 70,



            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Deuda interes capital",
                Tamaño = 6,
                Posx = 324,                         //Mes
                Posy = 179,
                Ancho = 70,



            };

            ListaPre.Add(Campos);
            Campos = new Fuentes
            {
                Texto = "Deuda capital",
                Tamaño = 6,
                Posx = 324,                         //Mes
                Posy = 172,
                Ancho = 70,



            };

            ListaPre.Add(Campos);
            #endregion

            #region Periodo Consumo
            Campos = new Fuentes
            {
                Texto = "Desde - Hasta",
                Tamaño = 8,
                Posx = 170,                         //Mes
                Posy = 95,
                Ancho = 50,
                Negrita = true,



            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "-",
                Tamaño = 8,
                Posx = 195,                         //Mes
                Posy = 80,
                Ancho = 4,
                Negrita = true,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER



            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Pago oportuno hasta",
                Tamaño = 8,
                Posx = 263,                         //Mes
                Posy = 95,
                Ancho = 70,
                Negrita = true,



            };

            ListaPre.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Factura No.",
                Tamaño = 8,
                Posx = 420,                         //Mes
                Posy = 60,
                Ancho = 50,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT



            };

            ListaPre.Add(Campos);


            #endregion




        }
    }
}
