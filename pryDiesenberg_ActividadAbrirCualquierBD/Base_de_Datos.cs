using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryDiesenberg_ActividadAbrirCualquierBD
{
    internal class Base_de_Datos
    {
        public class BaseDeDatos
        {
            public OleDbConnection CNN;
            public string ERROR;
            public bool Conectar(string cadena)
            {
                try
                {
                    CNN = new OleDbConnection(cadena);
                    CNN.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    ERROR = ex.Message;
                    return false;
                }
            }
            public void Desconectar()
            {
                if (CNN != null && CNN.State == ConnectionState.Open)
                    CNN.Close();
            }
            public DataTable Consultar(string sql)
            {
                DataTable tabla = new DataTable();

                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter(sql, CNN);
                    da.Fill(tabla);
                }
                catch (Exception ex)
                {
                    ERROR = ex.Message;
                }

                return tabla;
            }
        }
    }
}

