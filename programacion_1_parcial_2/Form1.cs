using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Importamos esto para poder trabajar con archivos

namespace programacion_1_parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //path al directorio donde guardo mis files
        string DATA_PATH = @"Q:\Documents\UAI\programacion_1\programacion_1_parcial_2\programacion_1_parcial_2\data\"; //Directorio donde vamos a guardar los archivos

        //evento buttonConsultar_Click para consultar con los archivos la información solicitada
        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            listBoxFacturas.Items.Clear();
            bool pares, impares, menores10k, mayoresIguales10k;
            pares = impares = menores10k = mayoresIguales10k = false;

            if (checkBoxFacturasPares.Checked)
                pares = true;

            if (checkBoxFacturasImpares.Checked)
                impares = true;

            if (checkBoxMenores10k.Checked)
                menores10k = true;

            if (checkBoxMayoresIguales10k.Checked)
                mayoresIguales10k = true;

            //llamado a la función para imprimir las facturas según los filtros seleccionados
            ImprimirFacturas(pares, impares, menores10k, mayoresIguales10k);
        }

        //método ImprimirFacturas para imprimir las facturas en el listbox según los filtros seleccinoados
        private void ImprimirFacturas(bool _pares, bool _impares, bool _menores10k, bool _mayoresIguales10k)
        {

            string pathEncabezado = DATA_PATH + "encabezado.txt";
            FileStream archivoEncabezado = new FileStream(pathEncabezado, FileMode.Open);
            StreamReader lectorEncabezado = new StreamReader(archivoEncabezado);

            string[] vectorRegistrosEncabezado = new string[4];
            string[] vectorRegistrosDetalle = new string[5];
            string registroDetalle;
            string registroEncabezado;

            int facturaAcumulador = 0;
            int acumulador = 0;

            string facturaActual = "1001"; //primer factura


            while (lectorEncabezado.Peek() > -1) //while para recorrer el archivo de encabezados
            {
                registroEncabezado = lectorEncabezado.ReadLine();
                vectorRegistrosEncabezado = registroEncabezado.Split(';');

                //aplicamos el filtro para mostrar solo las facturas pares
                if((_pares && !_impares) && (Convert.ToInt32(facturaActual) % 2 != 0))
                {
                    facturaActual = Convert.ToString(Convert.ToInt32(facturaActual) + 1);
                    continue;
                }//fin del if

                //aplicamos el filtro para mostrar solo las facturas impares
                else if((!_pares && _impares) && (Convert.ToInt32(facturaActual)%2 == 0))
                {
                    facturaActual = Convert.ToString(Convert.ToInt32(facturaActual) + 1);
                    continue;
                }//fin del if

                //aplicamos el filtro para nm
                else if((!_pares && !_impares))
                {
                    break;
                }

                if (vectorRegistrosEncabezado[0] == facturaActual)
                {
                    
                    listBoxFacturas.Items.Add("******************************************************************************************************");
                    listBoxFacturas.Items.Add("Factura Nro: " + vectorRegistrosEncabezado[0] + "\t Fecha: " + vectorRegistrosEncabezado[3] + "Nombre; " + vectorRegistrosEncabezado[2]);
                    listBoxFacturas.Items.Add("***");
                    
                    string pathDetalle = DATA_PATH + "detalle.txt";
                    FileStream archivoDetalle = new FileStream(pathDetalle, FileMode.Open);
                    StreamReader lectorDetalle = new StreamReader(archivoDetalle);

                    while (lectorDetalle.Peek() > -1)
                    {
                        registroDetalle = lectorDetalle.ReadLine();
                        vectorRegistrosDetalle = registroDetalle.Split(';');

                        if (vectorRegistrosEncabezado[0] == vectorRegistrosDetalle[0]) //apareo de encabezado.txt y detalle.txt
                        {
                            acumulador = acumulador + 1;
                            facturaAcumulador += Convert.ToInt32(vectorRegistrosDetalle[3]) * Convert.ToInt32(vectorRegistrosDetalle[4]);
                            listBoxFacturas.Items.Add(vectorRegistrosDetalle[1] + "\t" + vectorRegistrosDetalle[2] + "\t" + vectorRegistrosDetalle[3] + "\t" + vectorRegistrosDetalle[4]);
                        }
                    }

                    lectorDetalle.Close();
                    archivoDetalle.Close();
                }
                
                facturaActual = Convert.ToString(Convert.ToInt32(facturaActual) + 1);
                listBoxFacturas.Items.Add("***");
                listBoxFacturas.Items.Add("Total: " + facturaAcumulador);

                int lineasListbox = listBoxFacturas.Items.Count - 1;

                //borramos las facturas que no cumplan con el filtro seleccionado
                if((_menores10k && !_mayoresIguales10k) && facturaAcumulador>=10000)
                {
                    for (int i = lineasListbox; i >= (lineasListbox - 4 - acumulador); i--)
                        listBoxFacturas.Items.RemoveAt(i);
                }
                
                //borramos la factura que no cumpla con el filtro seleccionado
                else if((!_menores10k && _mayoresIguales10k) && facturaAcumulador<=10000)
                {
                    for (int i = lineasListbox; i >= (lineasListbox - 4 - acumulador); i--)
                        listBoxFacturas.Items.RemoveAt(i);
                }

                //borramos todas las facturas
                else if(!_menores10k && !_mayoresIguales10k)
                {
                    listBoxFacturas.Items.Clear();
                    break;
                }

                facturaAcumulador = 0;
                acumulador = 0;
            }
            lectorEncabezado.Close();
            archivoEncabezado.Close();
        }

        //inicio del evento buttonSalir_Click para salir de la aplicación cuando se clickeé el botón
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//fin del evento buttonSalir_Click()
    }
}
