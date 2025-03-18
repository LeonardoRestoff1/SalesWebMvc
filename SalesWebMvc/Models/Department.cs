using System.Linq;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();
       
        public Department() { }

        public Department(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double VendasTotais(DateTime inicial, DateTime final)
        {
            return Vendedores.Sum(vendedor => vendedor.VendasTotais(inicial, final));
        }
    }
}
