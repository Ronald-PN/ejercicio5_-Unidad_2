using ejercicio4__Unidad_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ejercicio4__Unidad_2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var productos = new List<Producto>
            {
               new Producto {Id= 11,          Descripcion="Cargardor",           Precio= 150.25,        Fabricacion="Hecho En China" },
               new Producto {Id= 03,          Descripcion="Boligrafo",           Precio= 10.5 ,         Fabricacion= "Hecho en USA" },
               new Producto {Id= 5,           Descripcion="Cuaderno",            Precio= 85.45 ,        Fabricacion= "Hecho en Rep. Dom." },
               new Producto {Id= 09,          Descripcion="Borrador",            Precio= 15.99 ,        Fabricacion= "Hecho en Rep. Dom." },
               new Producto {Id= 001,         Descripcion="Fichas",              Precio= 45.25,         Fabricacion= "Hecho en Panamá" },
            };

            //SELECCIONO EL PRODUCTO CON EL ID DE PREFERENCIA
            // var listaProducto = from Producto in productos
            //  where Producto.Id==03
            //select Producto;

            //SELECCIONO EL PRODUCTO CUYO PRECIO SEA MAYOR QUE 20
            //var listaProducto = from Producto in productos
            //where Producto.Precio>20
            // select Producto;

            // SELECCIONO EL PRODUCTO CUYO PRECIO SEA MENOR QUE 70
            // var listaProducto = from Producto in productos
            // where Producto.Precio<70
            // select Producto;

            //SELECCIONO EL PRODUCTO POR LA CANTIDAD DE LETRAS

            //var listaProducto = from Producto in productos
            //where Producto.Descripcion.Length==9
            // select Producto;

            //SELECCIONO EL PRODUCTO QUE CONTANGA LA LETRA "I"
            // var listaProducto = from Producto in productos
            // where Producto.Descripcion.Contains("i")
            // select Producto;

            //SELECCIONO EL PRODUCTO QUE ESTAN FABRICADOS EN UN DETERMINADO PAIS
            var listaProducto = from Producto in productos
                                where Producto.Fabricacion.Contains("Rep. Dom.")
                                select Producto;

            return View(listaProducto);

        
        }
    }
}