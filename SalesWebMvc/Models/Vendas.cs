using SalesWebMvc.Models.Enums;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public SaleStatus Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public Vendas() { }

        public Vendas(int id, DateTime data, double quantidade, SaleStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
