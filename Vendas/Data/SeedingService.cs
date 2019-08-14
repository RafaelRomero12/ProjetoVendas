using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Models;
using Vendas.Models.Enums;

namespace Vendas.Data
{
    public class SeedingService
    {
        private VendasContext _context;


        public SeedingService(VendasContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Vendedor.Any() ||
                _context.Venda.Any())
            {
                return; // O Banco de dados ja foi populado!!!
            }

            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Eletronicos");
            Department d3 = new Department(3, "Livros");
            Department d4 = new Department(4, "Smartphones");

            Vendedor v1 = new Vendedor(1, "Luis", "luis@gmail.com", new DateTime(1998, 1, 10), 1000.0, d1);
            Vendedor v2 = new Vendedor(2, "Carlos", "carlos@gmail.com", new DateTime(1992, 8, 12), 1200.0, d2);
            Vendedor v3 = new Vendedor(3, "Carla", "carla@gmail.com", new DateTime(1993, 4, 5), 2000.0, d3);
            Vendedor v4 = new Vendedor(4, "Ana", "ana@gmail.com", new DateTime(1994, 6, 16), 2400.0, d4);
            Vendedor v5 = new Vendedor(5, "Leticia", "leticia@gmail.com", new DateTime(1988, 8, 8), 3000.0, d2);
            Vendedor v6 = new Vendedor(6, "Mauro", "mauro@gmail.com", new DateTime(1995, 7, 11), 3500.0, d1);

            Venda vnd1 = new Venda(1, new DateTime(2018, 09, 25), 11000.0, StatusVenda.Finalizado, v1);
            Venda vnd2 = new Venda(2, new DateTime(2018, 09, 4), 7000.0, StatusVenda.Finalizado, v5);
            Venda vnd3 = new Venda(3, new DateTime(2018, 09, 13), 4000.0, StatusVenda.Cancelado, v4);
            Venda vnd4 = new Venda(4, new DateTime(2018, 09, 1), 8000.0, StatusVenda.Finalizado, v1);
            Venda vnd5 = new Venda(5, new DateTime(2018, 09, 21), 3000.0, StatusVenda.Finalizado, v3);
            Venda vnd6 = new Venda(6, new DateTime(2018, 09, 15), 2000.0, StatusVenda.Finalizado, v1);
            Venda vnd7 = new Venda(7, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Finalizado, v2);
            Venda vnd8 = new Venda(8, new DateTime(2018, 09, 11), 4000.0, StatusVenda.Finalizado, v4);
            Venda vnd9 = new Venda(9, new DateTime(2018, 09, 14), 11000.0, StatusVenda.Pendente, v6);
            Venda vnd10 = new Venda(10, new DateTime(2018, 09, 7), 9000.0, StatusVenda.Finalizado, v6);
            Venda vnd11 = new Venda(11, new DateTime(2018, 09, 13), 6000.0, StatusVenda.Finalizado, v2);
            Venda vnd12 = new Venda(12, new DateTime(2018, 09, 25), 7000.0, StatusVenda.Pendente, v3);
            Venda vnd13 = new Venda(13, new DateTime(2018, 09, 29), 10000.0, StatusVenda.Finalizado, v4);
            Venda vnd14 = new Venda(14, new DateTime(2018, 09, 4), 3000.0, StatusVenda.Finalizado, v5);
            Venda vnd15 = new Venda(15, new DateTime(2018, 09, 12), 4000.0, StatusVenda.Finalizado, v1);
            Venda vnd16 = new Venda(16, new DateTime(2018, 10, 5), 2000.0, StatusVenda.Finalizado, v4);
            Venda vnd17 = new Venda(17, new DateTime(2018, 10, 1), 12000.0, StatusVenda.Finalizado, v1);
            Venda vnd18 = new Venda(18, new DateTime(2018, 10, 24), 6000.0, StatusVenda.Finalizado, v3);
            Venda vnd19 = new Venda(19, new DateTime(2018, 10, 22), 8000.0, StatusVenda.Finalizado, v5);
            Venda vnd20 = new Venda(20, new DateTime(2018, 10, 15), 8000.0, StatusVenda.Finalizado, v6);
            Venda vnd21 = new Venda(21, new DateTime(2018, 10, 17), 9000.0, StatusVenda.Finalizado, v2);
            Venda vnd22 = new Venda(22, new DateTime(2018, 10, 24), 4000.0, StatusVenda.Finalizado, v4);
            Venda vnd23 = new Venda(23, new DateTime(2018, 10, 19), 11000.0, StatusVenda.Cancelado, v2);
            Venda vnd24 = new Venda(24, new DateTime(2018, 10, 12), 8000.0, StatusVenda.Finalizado, v5);
            Venda vnd25 = new Venda(25, new DateTime(2018, 10, 31), 7000.0, StatusVenda.Finalizado, v3);
            Venda vnd26 = new Venda(26, new DateTime(2018, 10, 6), 5000.0, StatusVenda.Finalizado, v4);
            Venda vnd27 = new Venda(27, new DateTime(2018, 10, 13), 9000.0, StatusVenda.Pendente, v1);
            Venda vnd28 = new Venda(28, new DateTime(2018, 10, 7), 4000.0, StatusVenda.Finalizado, v3);
            Venda vnd29 = new Venda(29, new DateTime(2018, 10, 23), 12000.0, StatusVenda.Finalizado, v5);
            Venda vnd30 = new Venda(30, new DateTime(2018, 10, 12), 5000.0, StatusVenda.Finalizado, v2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);

            _context.Venda.AddRange(vnd1, vnd2, vnd3, vnd4, vnd5, vnd6, vnd7, vnd8, vnd9, vnd10,
                                    vnd11, vnd12, vnd11, vnd14, vnd15, vnd16, vnd17, vnd18, vnd19, vnd20,
                                    vnd21, vnd22, vnd23, vnd24, vnd25, vnd26, vnd27, vnd28, vnd29, vnd30);

            _context.SaveChanges();

        }
    }
    
}
