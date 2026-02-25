using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcSqlMongoDemo.Models;
using MvcSqlMongoDemo.Data;
using MvcSqlMongoDemo.Services;

namespace MvcSqlMongoDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly MongoService _mongoService;

        public HomeController(AppDbContext context, MongoService mongoService)
        {
            _context = context;
            _mongoService = mongoService;
        }

        public async Task<IActionResult> Index()
        {
            // Obtener usuarios desde SQL Server
            var usuarios = _context.Usuarios.ToList();

            // Obtener registros desde MongoDB
            var registros = await _mongoService.GetRegistrosAsync();

            var viewModel = new UsuarioAccesoViewModel
            {
                Usuarios = usuarios,
                Registros = registros
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}