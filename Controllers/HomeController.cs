using System;
using Microsoft.AspNetCore.Mvc;
using programacion.models;

using System.Linq;

namespace programacion.controllers
{

    public class HomeController:Controller{

        private readonly DatabaseContext _context;

        public HomeController(DatabaseContext context)
        {
            _context = context;
        }


        public IActionResult Index(){
            return View(_context.Students.ToList());
        }
        
        public IActionResult Create(){
            return View();
        }

        public IActionResult Details(int? id){

           if (id == null)
            {
                return NotFound();
            }

            var student= _context.Students
                .SingleOrDefault(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Home/RegistrarFan
        [HttpPost]
        public IActionResult Registro(Student student){
            Console.WriteLine("Registrado");
            int age =DateTime.Now.Year - student.Birth.Year;
            Random  rnd = new Random();
            int numero = rnd.Next();
            student.Age = age;
            String curso= student.Curso;
            int cred=0;
            

            switch(curso){
                case "Matematica":
                    cred=4;
                break;
                case "Lenguaje":
                    cred=5;
                break;
                case "Fisica":
                    cred=6;
                break;
            }
           
            cred=student.Credito;
            _context.Add(student);
            _context.SaveChanges();

            return View(student);
        }
    }

}