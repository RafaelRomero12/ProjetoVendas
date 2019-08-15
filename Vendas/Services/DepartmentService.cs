using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models;

namespace Vendas.Services
{
    public class DepartmentService
    {
        private readonly VendasContext _context;

        public DepartmentService(VendasContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Nome).ToList();
        }

    }
}
