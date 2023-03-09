
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
        public static List<Fuentes> ListaCampos = new List<Fuentes>();
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

        
        public static void CamposVariables()
        {


            #region Detalle de Medicion
            Fuentes Campos = new Fuentes
            {
                Texto = Metodos.informacion.FORMATO.FR_ENCABEZADO.FACTURA.FACTCODI,
                Tamaño = 7,
                Posx = 272,                         //Marca
                Posy = 497,
                Ancho = 50,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER

            };


            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "1028418TECCBA",
                Tamaño = 7,
                Posx = 324,                        //Medidor
                Posy = 497,
                Ancho = 57,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "5",
                Tamaño = 7,
                Posx = 384,                         //Cifras
                Posy = 497,
                Ancho = 21,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "1",
                Tamaño = 7,
                Posx = 407,                         //Factor
                Posy = 497,
                Ancho = 22,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "Normales",
                Tamaño = 7,
                Posx = 430,                          //Clase
                Posy = 497,
                Ancho = 43,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "350",
                Tamaño = 7,
                Posx = 323,                          //Consumo Prox
                Posy = 475,
                Ancho = 29,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "550",
                Tamaño = 7,
                Posx = 353,                          //Observacion LECT
                Posy = 475,
                Ancho = 28,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "750",
                Tamaño = 7,
                Posx = 382,                          //LECT Anterior
                Posy = 475,
                Ancho = 32,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "950",
                Tamaño = 7,
                Posx = 415,                          //LECT Actual
                Posy = 475,
                Ancho = 28,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "1550",
                Tamaño = 7,
                Posx = 445,                          //Consumo
                Posy = 475,
                Ancho = 28,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "350",
                Tamaño = 7,
                Posx = 323,                          //Consumo Prox 2
                Posy = 462,
                Ancho = 29,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "550",
                Tamaño = 7,
                Posx = 353,                          //Observacion LECT2
                Posy = 462,
                Ancho = 28,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "750",
                Tamaño = 7,
                Posx = 382,                          //LECT Anterior2
                Posy = 462,
                Ancho = 32,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "950",
                Tamaño = 7,
                Posx = 415,                          //LECT Actual2
                Posy = 462,
                Ancho = 28,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "1550",
                Tamaño = 7,
                Posx = 445,                          //Consumo2
                Posy = 462,
                Ancho = 28,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER
            };
            ListaCampos.Add(Campos);
            #endregion

            #region Factura
            Campos = new Fuentes
            {
                Texto = "78244380",
                Tamaño = 7,
                Posx = 425,                         //Factura Numero
                Posy = 568,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER,
                Negrita = true

            };
            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "2022/02/02",
                Tamaño = 7,
                Posx = 425,                         //Factura fecha exp
                Posy = 553,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER,
                Negrita = true

            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "73569203",
                Tamaño = 7,
                Posx = 425,                         //REF. Pago electronico
                Posy = 538,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER,
                Negrita = true

            };
            ListaCampos.Add(Campos);
            #endregion

            #region Datos Personales
            Campos = new Fuentes
            {
                Texto = "David Santiago Galeano Ariza",
                Tamaño = 7,
                Posx = 95,                         //Nombre
                Posy = 516,
                Ancho = 100,
                Negrita = true


            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "1011320729",
                Tamaño = 7,
                Posx = 95,                         //Cedula
                Posy = 506,
                Ancho = 100,
                Negrita = true


            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "xxx-xxx-xxx",
                Tamaño = 7,
                Posx = 95,                         //Direccion
                Posy = 496,
                Ancho = 100,
                Negrita = true


            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Bogota",
                Tamaño = 7,
                Posx = 95,                         //Municipio
                Posy = 486,
                Ancho = 100,
                Negrita = true


            };
            ListaCampos.Add(Campos);
            #endregion

            #region Informacion Tecnica


            Campos = new Fuentes
            {
                Texto = "92586302",
                Tamaño = 8,
                Posx = 67,                         //Contrato
                Posy = 410,
                Ancho = 65,
                Negrita = true,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER

            };

            ListaCampos.Add(Campos);
            Campos = new Fuentes
            {
                Texto = " 19505501090 - 3042",
                Tamaño = 6,
                Posx = 93,                         //Ruta Reparto
                Posy = 381,
                Ancho = 60,
                Negrita = true


            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Residencial",
                Tamaño = 6,
                Posx = 93,                         //Categoria
                Posy = 374,
                Ancho = 60,
                Negrita = true


            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "1",
                Tamaño = 6,
                Posx = 93,                         //Nivel tension
                Posy = 367,
                Ancho = 60,
                Negrita = true


            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "T1135",
                Tamaño = 6,
                Posx = 93,                         //Transformador
                Posy = 360,
                Ancho = 60,
                Negrita = true


            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "16109",
                Tamaño = 6,
                Posx = 93,                         //Alimentador
                Posy = 353,
                Ancho = 60,
                Negrita = true


            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "505",
                Tamaño = 6,
                Posx = 93,                         //Ciclo
                Posy = 346,
                Ancho = 60,
                Negrita = true


            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "2",
                Tamaño = 6,
                Posx = 93,                         //Estrato
                Posy = 339,
                Ancho = 60,
                Negrita = true


            };
            ListaCampos.Add(Campos);
            #endregion

            #region Conceptos de energia
            Campos = new Fuentes
            {
                Texto = "Consumo Energía (Kwh) ",
                Tamaño = 8,
                Posx = 185,                         //Cargos
                Posy = 320,
                Ancho = 100,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Subsidio",
                Tamaño = 8,
                Posx = 185,                         //Cargos
                Posy = 310,
                Ancho = 100,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Ajuste por redondeo",
                Tamaño = 8,
                Posx = 185,                         //Cargos
                Posy = 300,
                Ancho = 100,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "295",
                Tamaño = 8,
                Posx = 305,                         //Cantidad
                Posy = 320,
                Ancho = 45,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "130",
                Tamaño = 8,
                Posx = 305,                         //Cantidad
                Posy = 310,
                Ancho = 45,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "772.2261$",
                Tamaño = 8,
                Posx = 350,                         //Valor Unit
                Posy = 320,
                Ancho = 45,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "362.24532$",
                Tamaño = 8,
                Posx = 350,                         //Valor Unit
                Posy = 310,
                Ancho = 45,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "227,806.70$",
                Tamaño = 8,
                Posx = 400,                         //Subtotal$
                Posy = 320,
                Ancho = 70,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "-47,113.61$",
                Tamaño = 8,
                Posx = 400,                         //Subtotal$
                Posy = 310,
                Ancho = 70,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "25.91$",
                Tamaño = 8,
                Posx = 400,                         //Subtotal$
                Posy = 300,
                Ancho = 70,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT


            };

            ListaCampos.Add(Campos);
            #endregion

            #region Indicadores de Calidad
            Campos = new Fuentes
            {
                Texto = "0",
                Tamaño = 6,
                Posx = 197,                         //HC
                Posy = 426,
                Ancho = 10,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "0",
                Tamaño = 6,
                Posx = 197,                         //HC
                Posy = 413,
                Ancho = 10,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "322",
                Tamaño = 6,
                Posx = 197,                         //HC
                Posy = 400,
                Ancho = 10,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "2.56",
                Tamaño = 6,
                Posx = 197,                         //HC
                Posy = 387,
                Ancho = 13,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "10.05",
                Tamaño = 6,
                Posx = 201,                         //HC
                Posy = 374,
                Ancho = 15,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "12",
                Tamaño = 6,
                Posx = 232,                         //Indicadores de calidad
                Posy = 426,
                Ancho = 14,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "20",
                Tamaño = 6,
                Posx = 232,                         //Indicadores de calidad
                Posy = 413,
                Ancho = 14,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "1",
                Tamaño = 6,
                Posx = 232,                         //Indicadores de calidad
                Posy = 387,
                Ancho = 14,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "10",
                Tamaño = 6,
                Posx = 232,                         //Indicadores de calidad
                Posy = 374,
                Ancho = 14,


            };

            ListaCampos.Add(Campos);
            #endregion

            #region Componentes de costos de prestacion de servicios
            Campos = new Fuentes
            {
                Texto = "280.58",
                Tamaño = 6,
                Posx = 50,                         //gm
                Posy = 295,
                Ancho = 17,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "50.31",
                Tamaño = 6,
                Posx = 50,                         //tm
                Posy = 285,
                Ancho = 17,


            };

            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "58.76",
                Tamaño = 6,
                Posx = 95,                         //pr
                Posy = 295,
                Ancho = 17,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "271.49",
                Tamaño = 6,
                Posx = 95,                         //Dn
                Posy = 285,
                Ancho = 21,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "859.34",
                Tamaño = 6,
                Posx = 108,                         //Costo Unitario
                Posy = 280,
                Ancho = 21,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "770.22",
                Tamaño = 6,
                Posx = 110,                         //Tarifa Aplicada
                Posy = 270,
                Ancho = 21,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "33.95",
                Tamaño = 6,
                Posx = 155,                         //rm
                Posy = 295,
                Ancho = 17,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "164.25",
                Tamaño = 6,
                Posx = 155,                         //Cv
                Posy = 285,
                Ancho = 17,


            };

            ListaCampos.Add(Campos);





            Campos = new Fuentes
            {
                Texto = "$2,950,000",
                Tamaño = 9,
                Posx = 51,                         //Cupo Disponible
                Posy = 225,
                Ancho = 100,
                Negrita = true,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER

            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$2,950,000",
                Tamaño = 6,
                Posx = 145,                         //Cupo Total
                Posy = 210,
                Ancho = 30,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$0",
                Tamaño = 6,
                Posx = 145,                         //Cupo Utilizado
                Posy = 200,
                Ancho = 30,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "3.041%MV (43.26%EA)",
                Tamaño = 6,
                Posx = 105,                         //Tasa
                Posy = 190,
                Ancho = 70,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$0",
                Tamaño = 6,
                Posx = 145,                         //Financiacion
                Posy = 180,
                Ancho = 30,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$0",
                Tamaño = 6,
                Posx = 145,                         //Interes
                Posy = 170,
                Ancho = 30,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$0",
                Tamaño = 6,
                Posx = 145,                         //Seguro Deudor
                Posy = 160,
                Ancho = 30,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };
            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "898113127",
                Tamaño = 15,
                Posx = 115,                         //Producto
                Posy = 135,
                Ancho = 75,
                Negrita = true

            };
            ListaCampos.Add(Campos);
            #endregion

            #region Ultimos 6 consumos
            Campos = new Fuentes
            {
                Texto = "DIC/23",
                Tamaño = 6,
                Posx = 260,                         //Mes
                Posy = 415,
                Ancho = 17,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "NOV/23",
                Tamaño = 6,
                Posx = 260,                         //Mes
                Posy = 407,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "OCT/23",
                Tamaño = 6,
                Posx = 260,                         //Mes
                Posy = 399,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "SEP/23",
                Tamaño = 6,
                Posx = 260,                         //Mes
                Posy = 391,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "AGO/23",
                Tamaño = 6,
                Posx = 260,                         //Mes
                Posy = 383,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "JUL/23",
                Tamaño = 6,
                Posx = 260,                         //Mes
                Posy = 375,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "362",
                Tamaño = 6,
                Posx = 287,                         //Mes
                Posy = 415,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "322",
                Tamaño = 6,
                Posx = 287,                         //Mes
                Posy = 407,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "315",
                Tamaño = 6,
                Posx = 287,                         //Mes
                Posy = 399,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "308",
                Tamaño = 6,
                Posx = 287,                         //Mes
                Posy = 391,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "299",
                Tamaño = 6,
                Posx = 287,                         //Mes
                Posy = 383,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "285",
                Tamaño = 6,
                Posx = 287,                         //Mes
                Posy = 375,
                Ancho = 20,


            };

            ListaCampos.Add(Campos);
            #endregion

            #region Periodo de Consumo
            Campos = new Fuentes
            {
                Texto = "08/12/2022",
                Tamaño = 6,
                Posx = 400,                         //Mes
                Posy = 415,
                Ancho = 30,



            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "08/12/2022",
                Tamaño = 6,
                Posx = 440,                         //Mes
                Posy = 415,
                Ancho = 30,



            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "08/12/2022",
                Tamaño = 8,
                Posx = 420,                         //Mes
                Posy = 390,
                Ancho = 50,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT,
                Negrita = true




            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "08/12/2022",
                Tamaño = 8,
                Posx = 420,                         //Mes
                Posy = 358,
                Ancho = 50,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT,
                Negrita = true




            };

            ListaCampos.Add(Campos);
            #endregion

            #region Facturacion Alumbrado Publico
            Campos = new Fuentes
            {
                Texto = "Tipo: Impuesto, Responsable Municipio POPAYÁN, A.C.M 010/1992 \r\n y 041/2016, Clausula 51 CCU, Atención Cra.6 No.4-21 C.A.M Tel \r\n 8317721-8317722",
                Tamaño = 4,
                Posx = 180,                         //Mes
                Posy = 210,
                Ancho = 130,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER





            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "Imp. Alumbrado Publico",
                Tamaño = 4,
                Posx = 325,                         //Mes
                Posy = 225,
                Ancho = 90,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER





            };

            ListaCampos.Add(Campos);

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "9,881,00",
                Tamaño = 4,
                Posx = 420,                         //Mes
                Posy = 225,
                Ancho = 60,
                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER





            };

            ListaCampos.Add(Campos);
            #endregion

            #region Estado de financiacion
            Campos = new Fuentes
            {
                Texto = "16-12-2022",
                Tamaño = 6,
                Posx = 250,                         //Mes
                Posy = 150,
                Ancho = 30,
            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$244,20,00",
                Tamaño = 6,
                Posx = 290,                         //Mes
                Posy = 150,
                Ancho = 30,

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$180,20,00",
                Tamaño = 6,
                Posx = 430,                         //Mes
                Posy = 200,
                Ancho = 40,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$9,20,00",
                Tamaño = 6,
                Posx = 430,                         //Mes
                Posy = 193,
                Ancho = 40,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$0",
                Tamaño = 6,
                Posx = 430,                         //Mes
                Posy = 186,
                Ancho = 40,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$0",
                Tamaño = 6,
                Posx = 430,                         //Mes
                Posy = 179,
                Ancho = 40,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$0",
                Tamaño = 6,
                Posx = 430,                         //Mes
                Posy = 172,
                Ancho = 40,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$190,600",
                Tamaño = 7,
                Posx = 440,                         //Mes
                Posy = 155,
                Ancho = 30,
                Negrita = true,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT

            };



            ListaCampos.Add(Campos);
            #endregion

            #region Facturacion de servicio
            Campos = new Fuentes
            {
                Texto = "08/12/2022",
                Tamaño = 8,
                Posx = 146,                         //Mes
                Posy = 80,
                Ancho = 40,
                Negrita = true,

            };

            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = " 07/01/2023",
                Tamaño = 8,
                Posx = 210,                         //Mes
                Posy = 80,
                Ancho = 40,
                Negrita = true,

            };

            ListaCampos.Add(Campos);


            Campos = new Fuentes
            {
                Texto = "23/01/2023",
                Tamaño = 8,
                Posx = 263,                         //Mes
                Posy = 80,
                Ancho = 70,
                Negrita = true,

                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "$190,600",
                Tamaño = 12,
                Posx = 380,                         //Mes
                Posy = 85,
                Ancho = 70,
                Negrita = true,

                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "953537",
                Tamaño = 8,
                Posx = 25,                         //Mes
                Posy = 65,
                Ancho = 70,
                Negrita = true,

                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "74586396",
                Tamaño = 8,
                Posx = 25,                         //Mes
                Posy = 32,
                Ancho = 70,
                Negrita = true,



                Alineamiento = iText.Layout.Properties.TextAlignment.CENTER

            };

            ListaCampos.Add(Campos);

            Campos = new Fuentes
            {
                Texto = "78244380",
                Tamaño = 8,
                Posx = 430,                         //Mes
                Posy = 50,
                Ancho = 40,
                Alineamiento = iText.Layout.Properties.TextAlignment.RIGHT



            };

            ListaCampos.Add(Campos);
            #endregion  





        }

    }
}
