using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            //var query = from p in context.Products
            //            select p;

            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            ////INSERTAR DATOS
            Products np = new Products();
            np.ProductName = "Peruvian Coffee";
            np.SupplierID = 20;
            np.CategoryID = 1;
            np.QuantityPerUnit = "10 pkgs";
            np.UnitPrice = 25;

            //Ejecución de consulta
            context.Products.InsertOnSubmit(np);
            context.SubmitChanges();

            ////MODIFICAR DATOS
            var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();

            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;

            //Ejecución de la transacción
            context.SubmitChanges();

            var query = from pq in context.Products
                        where pq.ProductName == "Tofu"
                        select pq;

            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            }
            Console.ReadLine();


            ////ELIMINACIÓN DE DATOS
            var productEliminar = (from pe in context.Products
                                   where pe.ProductID == 78
                                   select pe).FirstOrDefault();

            //Ejecución de la consulta
            context.Products.DeleteOnSubmit(productEliminar);
            context.SubmitChanges();

            var query3 = from pq3 in context.Products
                         where pq3.CategoryID == 1
                         select pq3;

            foreach (var prod3 in query3)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Price={2} \t Stock={3}", prod3.ProductID, prod3.ProductName,
                    prod3.UnitPrice, prod3.UnitsInStock);
            }

            Console.ReadLine();

            // 1.Listar ID, nombre productos cuyo nombre incluye la palabra “Queso”

            Console.WriteLine("I. Listar ID, nombre de los productos con la palabra “Queso”");
            var queryQueso = from p in context.Products
                             where p.ProductName.Contains("Queso")
                             select p;

            foreach (var prod in queryQueso)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            }
            Console.WriteLine();

            ////2.listar ID, nombre, presentación (QuantityPerUnit) productos cuya presentación
            ////sea paquetes (pkg o pkgs)

            Console.WriteLine("II.	Listar ID, nombre, presentación (QuantityPerUnit) " +
                " de los productos cuya presentación sea paquetes (pkg o pkgs) \n");

            var queryPaquete = from p in context.Products
                               where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs")
                               select p;
                        Console.WriteLine("{0, -5} {1, -40} {2, -30} \n", "ID", "NAME", "PRESENTATION");
            foreach (var prod in queryPaquete)
            {
                Console.WriteLine("{0, -5} {1, -40} {2, -30}",
                    prod.ProductID, prod.ProductName, prod.QuantityPerUnit);
            }
            Console.WriteLine();
            ////3.Listar nombre, precio de productos que empiezan con la letra A

            Console.WriteLine("III.	Listar nombre, precio de productos que empiezan con la letra A \n");

            var queryProdsA = from p in context.Products
                              where p.ProductName.ToLower().StartsWith("A")
                              select p;

            Console.WriteLine("{0, -5} {1, -40} {2, -30} \n", "ID", "NAME", "PRECIO");
            foreach (var prod in queryProdsA)
            {
                Console.WriteLine("{0, -5} {1, -40} {2, -30}",
                    prod.ProductID, prod.ProductName, prod.UnitPrice);
            }
            Console.WriteLine();

            //4.Listar ID, nombre de productos sin stock
            Console.WriteLine("IV.	Listar ID, nombre de productos sin stock \n");

            var queryStockCero = from p in context.Products
                                 where p.UnitsInStock == 0
                                 select p;

            Console.WriteLine("{0, -5} {1, -40} {2, -30} \n", "ID", "NAME", "STOCK");
            foreach (var prod in queryStockCero)
            {
                Console.WriteLine("{0, -5} {1, -40} {2, -30}",
                    prod.ProductID, prod.ProductName, prod.UnitsInStock);
            }
            Console.WriteLine();

            //5.Listar ID, nombre de productos descontinuados
            Console.WriteLine("V.	Listar ID, nombre de productos descontinuados \n");

            var queryProdsDiscontinued = from p in context.Products
                                         where p.Discontinued == true
                                         select p;

            Console.WriteLine("{0, -5} {1, -40} {2, -30} \n", "ID", "NAME", "DISCONTINUADO?");
            foreach (var prod in queryProdsDiscontinued)
            {
                Console.WriteLine("{0, -5} {1, -40} {2, -30}",
                    prod.ProductID, prod.ProductName, prod.Discontinued);
            }
            Console.WriteLine();



            //REGISTRO DE UNA CATEGORIA EN LA BASE DE DATOS

            Categories ncat = new Categories();
            ncat.CategoryName = "Juegos";
            ncat.Description = "Dota 2";

            //Ejecución de la consulta
            context.Categories.InsertOnSubmit(ncat);
            context.SubmitChanges();

            //Verificando la insercción
            var queryCat = from c in context.Categories
                           select c;

            Console.WriteLine("{0, -5} {1, -20} {2, -30} \n", "ID", "NAME", "DESCRIPCIÓN");
            foreach (var cat in queryCat)
            {
                Console.WriteLine("{0, -5} {1, -40} {2, -30}",
                    cat.CategoryID, cat.CategoryName, cat.Description);
            }


            //Listar ID, nombre de producto, nombre del proveedor (Suppliers/CompanyName)

            var queryCatDairy = from prod in context.Products
                                where prod.Categories.CategoryName == "Dairy Products"
                                select prod;

            Console.WriteLine("{0, -5} {1, -40} {2, -30} \n", "ID", "NAME", "PROVEEDOR");
            foreach (var prods in queryCatDairy)
            {
                Console.WriteLine("{0, -5} {1, -40} {2, -30}",
                    prods.ProductID, prods.ProductName, prods.Suppliers.CompanyName);
            }
            Console.WriteLine();
            //Listar los productos de USA

            var queryProvUsa = from prod in context.Products
                               where prod.Suppliers.Country.ToLower() == "usa"
                               select prod;

            Console.WriteLine("{0, -5} {1, -40} {2, -30} {3, -10} \n", "ID", "NAME", "PROVEEDOR", "PAÍS");
            foreach (var prods in queryProvUsa)
            {
                Console.WriteLine("{0, -5} {1, -40} {2, -30} {3, -10}",
                    prods.ProductID, prods.ProductName, prods.Suppliers.CompanyName, prods.Suppliers.Country);
            }

            Console.ReadLine();

        }
    }
}
