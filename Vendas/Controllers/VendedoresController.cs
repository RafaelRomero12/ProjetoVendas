using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vendas.Models;
using Vendas.Models.ViewModels;
using Vendas.Services;

namespace Vendas.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        private readonly DepartmentService _departmentService;

        public VendedoresController(VendedorService vendedorService, DepartmentService departmentService)
        {
            _vendedorService = vendedorService;
            _departmentService = departmentService;
        }


        public IActionResult Index()
        {
            var list = _vendedorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new VendedorFormViewModel { Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorService.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}