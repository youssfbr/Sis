using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SisTest.Models;

namespace SisTest.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> list = new List<Cliente>();
            list.Add(new Cliente { Id = 1, Nome = "Alisson", Sexo = "M", Email = "youssfbr@gmail.com", Telefone = "99999999" });
            list.Add(new Cliente { Id = 2, Nome = "Lilica", Sexo = "F", Email = "lilica@gmail.com", Telefone = "8754967998" });
            return View(list);
        }
    }
}