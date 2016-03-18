﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.c3_dominio.entidad;
namespace Modelo.c3_dominio.contrato
{
    public interface IProductoDAO
    {
        void crearProducto(Producto producto);
        void modificarProducto(Producto producto);
        void eliminarProducto(Producto producto);
        Producto buscarProducto(int codigoProducto);
        List<Producto> buscarProducto();
    }
}
