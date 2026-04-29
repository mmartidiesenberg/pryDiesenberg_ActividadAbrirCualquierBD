using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pryDiesenberg_ActividadAbrirCualquierBD.Base_de_Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;





namespace pryDiesenberg_ActividadAbrirCualquierBD
{
    public partial class frmPrincipal : Form
    {
        BaseDeDatos bd = new BaseDeDatos();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void CargarTablas()
        {
            DataTable tablas = bd.CNN.GetSchema("Tables");

            cmbTablas.Items.Clear();

            foreach (DataRow row in tablas.Rows)
            {
                string nombre = row["TABLE_NAME"].ToString();

                if (!nombre.StartsWith("MSys"))
                    cmbTablas.Items.Add(nombre);
            }
        }
        private string ObtenerCadenaConexion(string ruta)
        {
            string ext = Path.GetExtension(ruta).ToLower();

            if (ext == ".mdb")
                return $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={ruta}";

            if (ext == ".accdb")
                return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";

            return null;
        }
        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla = cmbTablas.SelectedItem.ToString();

            DataTable datos = bd.Consultar($"SELECT * FROM [{tabla}]");

            dgvDatos.DataSource = datos;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Bases de datos (*.mdb;*.accdb)|*.mdb;*.accdb";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;
                string cadena = ObtenerCadenaConexion(ruta);

                if (cadena == null)
                {
                    MessageBox.Show("Formato No Soportado");
                    return;
                }

                if (bd.Conectar(cadena))
                {
                    cmbTablas.Items.Clear();
                    dgvDatos.DataSource = null;
                    CargarTablas();
                }
                else
                {
                    MessageBox.Show(bd.ERROR);
                }
            }
            MessageBox.Show("Base de Datos seleccionada correctamente, ahora elija una tabla para mostrar sus datos.");
        }
    }
}


