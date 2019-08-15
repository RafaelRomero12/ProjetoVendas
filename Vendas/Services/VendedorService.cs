using Microsoft.EntityFrameworkCore;
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

        public Vendedor FindById(int id)
        {
            return _context.Vendedor.Include(obj => obj.department).FirstOrDefault(obj => obj.id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }

    }
}
