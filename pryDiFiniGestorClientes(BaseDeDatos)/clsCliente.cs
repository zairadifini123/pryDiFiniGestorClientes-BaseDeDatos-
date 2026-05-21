using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace pryDiFiniGestorClientes_BaseDeDatos_
{
    internal class clsCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        //Adaptador para trae datos de la tabla
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        //Que tipo de base de datos se va a usar y cual es, donde esta
        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";

        //Que tabla vamos a usar
        private String Tabla = "Cliente";

        //Variables para calcular etiquetas
        private Decimal deuda;
        private Int32 cantidad;

        //Propiedades / Funciones para pasar las variables al formulario
        public Decimal TotalDeuda
        {
            get { return deuda; } 
        }

        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }

        public Decimal PromedioDeuda
        {
            get { return deuda / cantidad; } 
        }



        public void Listar(DataGridView Grilla)
        {
            //Para que no se cierre sino que te avise cual es el error
            try
            {
                conexion.ConnectionString = CadenaConexion; //Lo conecta a la base de datos
                conexion.Open(); //Se abre la base de datos

                comando.Connection = conexion; //Se abre el comando que ejecute la conexion
                comando.CommandType = CommandType.TableDirect; //Tipo de tabla que se va a usar
                comando.CommandText = Tabla;  //Cual es la tabla

                adaptador = new OleDbDataAdapter(comando); //Conecta el adaptador
                DataSet DS = new DataSet(); //Trae todos los datos de la tabla en una variable, DataSet (tabla virtual cargada en la memoria) 
                adaptador.Fill(DS); //Para traer TODOS los datos

                Grilla.DataSource = DS.Tables[0]; //Trae en la grilla la primer tabla por eso pones 0

                conexion.Close(); //Se cierra
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString()); 
            }
        }

        public void ListarDeudores(DataGridView Grilla)
        {
            //Para que no se cierre sino que te avise cual es el error
            try
            {
                conexion.ConnectionString = CadenaConexion; //Lo conecta a la base de datos
                conexion.Open(); //Se abre la base de datos

                comando.Connection = conexion; //Se abre el comando que ejecute la conexion
                comando.CommandType = CommandType.TableDirect; //Tipo de tabla que se va a usar
                comando.CommandText = Tabla;  //Cual es la tabla

                OleDbDataReader DR = comando.ExecuteReader(); //Lee los datos que vamos trayendo, no todos

                cantidad = 0;
                deuda = 0;
                Grilla.Rows.Clear(); 

                if (DR.HasRows)
                {
                    while (DR.Read()) //Lee 
                    {
                        if (DR.GetDecimal(2) > 0) //Valida que solo sean los deudores
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2)); //Traes la posicion 0, 1, 2 de la tabla
                            cantidad++;
                            deuda = deuda + DR.GetDecimal(2);
                        }
                    }
                }

                conexion.Close(); //Se cierra
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

    }
}
