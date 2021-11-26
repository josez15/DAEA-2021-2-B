using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar(string Busqueda)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Moritz",
                Apellido = "Morgan",
                Direccion = "Av. Evergreen 123",
                FechaNacimiento = Convert.ToDateTime("2000-11-11"),
                Email = "Morgan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los Manzanos 101",
                FechaNacimiento = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNacimiento = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });
            if (!String.IsNullOrEmpty(Busqueda))
            {
                personas = personas.Where(s => s.Nombre.ToLower().Contains(Busqueda.ToLower()) || s.Apellido.ToLower().Contains(Busqueda.ToLower())).ToList();
            }
            return View(personas);

        }

        public ActionResult Mostrar(int id)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Moritz",
                Apellido = "Morgan",
                Direccion = "Av. Evergreen 123",
                FechaNacimiento = Convert.ToDateTime("2000-11-11"),
                Email = "Morgan@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "Av. Progreso 325",
                FechaNacimiento = Convert.ToDateTime("1995-10-28"),
                Email = "maria@mail.com"
            });
            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av. Los manzamos 101",
                FechaNacimiento = Convert.ToDateTime("1982-02-14"),
                Email = "carlos@mail.com"
            });

            Persona persona = (from p in personas
                               where p.PersonaID == id
                               select p).FirstOrDefault();

            return View(persona);
        }
    }
}