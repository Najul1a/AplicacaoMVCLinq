using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult index()
        {

            return View();
        }

        public IActionResult GetClientes()
        {
            Clientes c1 = new Clientes(1, "Alice", "alice@gmail.com", "1234-5678", new DateOnly(2001, 6, 11));

            Clientes c2 = new Clientes(2, "Ana", "anagereiias@gmail.com", "1234-5678", new DateOnly(2001, 8, 15));

            Clientes c3 = new Clientes(3, "Julia", "juliageremias1@gmail.com", "1234-5678", new DateOnly(2002, 6, 19));

            Clientes c4 = new Clientes(4, "Bea", "beanascimento@gmail.com", "1234-5678", new DateOnly(2005, 9, 21));

            Clientes c5 = new Clientes(5, "Clara", "clarachiaramontte@gmail.com", "1234-5678", new DateOnly(2003, 6, 21));

            Clientes c6 = new Clientes(6, "Livia", "liviasolla@gmail.com", "1234-5678", new DateOnly(2000, 4, 17));

            List<Clientes> listclientes = new List<Clientes>();

            listclientes.Add(c1);
            listclientes.Add(c2);
            listclientes.Add(c3);
            listclientes.Add(c4);
            listclientes.Add(c5);
            listclientes.Add(c6);


            return View(listclientes);
        }
    }
}
