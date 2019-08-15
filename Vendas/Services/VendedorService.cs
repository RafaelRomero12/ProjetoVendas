using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models;

namespace Vendas.Services
{
    public class VendedorService
    {
        private readonly VendasContext _context;

        public VendedorService(VendasContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor obj)
        {
           
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
