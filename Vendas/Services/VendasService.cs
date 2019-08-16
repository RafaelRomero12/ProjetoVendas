using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models;

namespace Vendas.Services
{
    public class VendasService
    {
        private readonly VendasContext _context;

        public VendasService(VendasContext context)
        {
            _context = context;
        }

        public async Task<List<Venda>> FindByDateAsync(DateTime? minData, DateTime? maxData)
        {
            var resultado = from obj in _context.Venda select obj;
            if (minData.HasValue)
            {
                resultado = resultado.Where(x => x.data >= minData.Value);
            }
            if (maxData.HasValue)
            {
                resultado = resultado.Where(x => x.data <= maxData.Value);
            }
            return await resultado.Include(x => x.vendedor).Include(x => x.vendedor.department).OrderByDescending(x => x.data).ToListAsync();
        }
    }
}
