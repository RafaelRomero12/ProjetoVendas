using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models;
using Vendas.Services.Exceptions;

namespace Vendas.Services
{
    public class VendedorService
    {
        private readonly VendasContext _context;

        public VendedorService(VendasContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }

        public async Task InsertAsync(Vendedor obj)
        {
           
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Vendedor> FindByIdAsync(int id)
        {
            return await _context.Vendedor.Include(obj => obj.department).FirstOrDefaultAsync(obj => obj.id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Vendedor.FindAsync(id);
            _context.Vendedor.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync (Vendedor obj)
        {
            bool verifica = await _context.Vendedor.AnyAsync(x => x.id == obj.id);
            if (!verifica)
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                _context.Update(obj);

               await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
