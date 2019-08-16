using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vendas.Services;

namespace Vendas.Controllers
{
    public class VendasController : Controller
    {
        private readonly VendasService _vendasService;
        public VendasController(VendasService vendasService)
        {
            _vendasService = vendasService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? minData, DateTime? maxData)
        {
            if (!minData.HasValue)
            {
                minData = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!maxData.HasValue)
            {
                maxData = DateTime.Now;
            }

            ViewData["minData"] = minData.Value.ToString("yyyy-MM-dd");
            ViewData["maxData"] = maxData.Value.ToString("yyyy-MM-dd");

            var resultado = await _vendasService.FindByDateAsync(minData, maxData);
            return View(resultado);
        }

        public IActionResult BuscaGrupo()
        {
            return View();
        }
    }
}