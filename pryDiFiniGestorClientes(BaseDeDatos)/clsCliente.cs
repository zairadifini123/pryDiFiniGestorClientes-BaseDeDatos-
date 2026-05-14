using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms; 

namespace pryDiFiniGestorClientes_BaseDeDatos_
{
    internal class clsCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        //Trae datos de la tabla
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        //Que tipo de base de datos se va a usar y cual es, donde esta
        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";

        //Que tabla vamos a usar
        private String Tabla = "Cliente"; 

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
                DataSet DS = new DataSet(); //Trae todos los datos de la tabla en una variable, tabla virtual cargada en la memoria 
                adaptador.Fill(DS); //Para traer TODOS los datos

                Grilla.DataSource = DS.Tables[0]; //Trae en la grilla la primer tabla por eso pones 0

                conexion.Close(); //Se cierra
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString()); 
            }
        }

    }
}
