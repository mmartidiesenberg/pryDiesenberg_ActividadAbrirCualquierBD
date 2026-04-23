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
            string carpeta = Path.Combine(Application.StartupPath, "Datos");

            if (!Directory.Exists(carpeta))
                return;

            var archivos = Directory.GetFiles(carpeta, "*.*")
                .Where(f => f.EndsWith(".mdb") || f.EndsWith(".accdb"))
                .ToArray();

            cmbBD.Items.Clear();

            foreach (var archivo in archivos)
            {
                string nombre = Path.GetFileNameWithoutExtension(archivo);

                // sacar el número inicial (ej: 2_)
                if (nombre.Contains("_"))
                    nombre = nombre.Substring(nombre.IndexOf("_") + 1);

                cmbBD.Items.Add(nombre);
            }
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

        private void cmbBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cmbBD.SelectedItem.ToString();
            string carpeta = Path.Combine(Application.StartupPath, "Datos");
            string archivo = Directory.GetFiles(carpeta, "*.*")
                .FirstOrDefault(f => Path.GetFileNameWithoutExtension(f).Contains(nombre));

            if (archivo == null) return;

            bd.Desconectar();
            string cadena = ObtenerCadenaConexion(archivo); // acá se pasa el provider correcto
            if (cadena == null) return;

            if (bd.Conectar(cadena))
                CargarTablas();
            else
                MessageBox.Show("Error: " + bd.ERROR);
        }

        private void cmbTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTablas.SelectedItem == null) return;
            string tabla = cmbTablas.SelectedItem.ToString();
            DataTable datos = bd.Consultar($"SELECT * FROM [{tabla}]");
            dgvDatos.DataSource = datos;
        }
    }

        
}


