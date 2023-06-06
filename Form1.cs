using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Reporteconfigurable
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=Northwind;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Helperconnection metodo = new Helperconnection(connectionString);
            List<string> Column = metodo.Mostrar();

            foreach (string col in Column)
            {
               
                if (listView2.Items.Count == 0)
                {
                    listView1.Items.Add(col);

                }
                else
                {
                    listView1.Items.Remove(new ListViewItem(col));

                }
               
                
                
            }
        }

        private void btnCrossRigth_Click(object sender, EventArgs e)
        {
            Helperconnection Data = new Helperconnection(connectionString);
            // Obtener los datos del procedimiento almacenado
            DataTable dataTable = Data.ShowData();
            // Limpiar el DataGridView
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            try
            {
                foreach (ListViewItem item in listView1.CheckedItems)
                {

                    ListViewItem Newitem = new ListViewItem(item.Text);
                    dataGridView1.Columns.Add(item.Text, item.Text);
                    listView2.Items.Add(Newitem);
                    listView1.Items.Remove(item);
                }
                //Instancia para conectar a la base de datos               

                foreach (DataRow columna in dataTable.Rows)
                {
                    object[] cellvalues = new object[dataGridView1.ColumnCount];

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        string columNme = dataGridView1.Columns[i].HeaderText;
                        cellvalues[i] = columna[columNme];
                    }
                    dataGridView1.Rows.Add(cellvalues);
                }

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }  

        }

        private void btnCrossLeft_Click(object sender, EventArgs e)
        {
            Helperconnection Data = new Helperconnection(connectionString);

            // Obtener los datos del procedimiento almacenado
            DataTable dataTable = Data.ShowData();
            try
            {
                foreach (ListViewItem item in listView2.CheckedItems)
                {
                    List<ListViewItem> originalItem = new List<ListViewItem>();
                   originalItem.Add(item);
                    dataGridView1.Columns.Remove(item.Text);
                    listView1.Items.Add(originalItem[item.Index]);
                    listView2.Items.Remove(item);
                    
                }
                
                foreach (DataRow columna in dataTable.Rows)
                {
                    //object[] cellvalues = new object[dataGridView1.ColumnCount];

                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        DataGridViewRow selectedRow = dataGridView1.SelectedRows[i];
                        dataGridView1.Rows.Remove(selectedRow);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error en la matrix" + ex);
            }

        }
    }
}
