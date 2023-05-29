using System;
using System.Collections.Generic;
using System.Text;
using Entidad;
using Datos;
using System.Data;

namespace Negocio
{
    public class negocio
    {
        datos dt = new datos();
        public void Crear(entidades enti)
        {
            dt.CrearProducto(enti);
        }

        public void Eliminar(entidades enti)
        {
            dt.EliminarProducto(enti);
        }

        public void Actualizar(entidades enti)
        {
            dt.ActualizarDireccion(enti);
        }

        public DataSet Leer()
        {
            return dt.ListarProductos();
        }
    }
}
