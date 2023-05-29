using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class datos
    {
        string consulta = "Server=localhost;User=root;Password=;Port=3306;database=primor";

        public void Conexion()
        {
            MySqlConnection conexion = new MySqlConnection(consulta);

            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
        public void CrearProducto(entidades enti)
        {
            MySqlConnection conexion = new MySqlConnection(consulta);
            conexion.Open();

            string consulta1 = "INSERT INTO `productos` (`id`,`cliente`, `producto`, `direccion`, `cantidad`) VALUES (NULL,'" + enti.cl + "', '" + enti.pr + "', '" + enti.dir + "', '" + enti.cant + "');";

            MySqlCommand codigo = new MySqlCommand(consulta1, conexion);
            codigo.ExecuteNonQuery();

            conexion.Close();
        }

        public void EliminarProducto(entidades enti)
        {
            MySqlConnection conexion = new MySqlConnection(consulta);
            conexion.Open();

            string consulta1 = "DELETE FROM `productos` WHERE `id`='" + enti.id + "';";

            MySqlCommand codigo = new MySqlCommand(consulta1, conexion);
            codigo.ExecuteNonQuery();

            conexion.Close();
        }

        public void ActualizarDireccion(entidades enti)
        {
            MySqlConnection conexion = new MySqlConnection(consulta);
            conexion.Open();

            string consulta1 = "UPDATE `productos` SET `direccion` = '" + enti.dir + "' WHERE `id` = '" + enti.id + "';";

            MySqlCommand codigo = new MySqlCommand(consulta1, conexion);
            codigo.ExecuteNonQuery();

            conexion.Close();
        }
        public DataSet ListarProductos()
        {
            MySqlConnection conexion = new MySqlConnection(consulta);
            conexion.Open();

            string consulta1 = ("SELECT * FROM `productos`;");
            MySqlDataAdapter adaptador;
            DataSet ds = new DataSet();

            adaptador = new MySqlDataAdapter(consulta1, conexion);
            adaptador.Fill(ds, "productos");

            return ds;
        }
    }
}
