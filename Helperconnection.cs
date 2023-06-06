using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Testing_Reporteconfigurable
{
    public class Helperconnection: HelperBase
    {
        public Helperconnection(string connectionString) 
        {
            this.connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True"; 
        }
        
        public DataTable ShowData()
        {
            
            using (var conection = new SqlConnection(connectionString))
            {
                conection.Open();
                SqlCommand cmd = new SqlCommand("ProductsClients", conection);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                using (SqlDataReader reader = cmd.ExecuteReader())                    
                {
                    if (reader.FieldCount > 0)
                    {
                        // Crear una tabla para almacenar los datos
                        

                        // Agregar las columnas al DataTable
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string column = reader.GetName(i);
                            dataTable.Columns.Add(column);
                        }

                        // Leer las filas del resultado y agregarlas al DataTable
                        while (reader.Read())
                        {
                            // Crear una nueva fila para cada registro en el resultado
                            DataRow row = dataTable.NewRow();

                            // Agregar los valores de cada columna al DataRow
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string columnN = reader.GetName(i);
                                object value = reader.GetValue(i);
                                row[columnN] = value;
                            }

                            // Agregar la fila al DataTable
                            dataTable.Rows.Add(row);
                        }

                        // Asignar el DataTable como origen de datos del DataGridView
                        
                    }


                }
                
                return  dataTable;
            }
        } 



        public List<string>  Mostrar()
        {
            List<string> columnName = new List<string>();
            using (var conection = new SqlConnection(connectionString))
            {                
                conection.Open();
                SqlCommand cmd = new SqlCommand("ProductsClients", conection);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            
                            for (int i = 0; i < reader.FieldCount; i++)
                            {                                
                                string column = reader.GetName(i);
                                columnName.Add(column);                               
                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un problema" + ex);
                    }
                    
                }
                
            }
            return columnName;


        }

    }
}
