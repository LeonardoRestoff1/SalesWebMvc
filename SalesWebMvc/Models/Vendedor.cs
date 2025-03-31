using System.Linq;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Department Departamento { get; set; }
        public int DepartamentoID { get; set; }
        public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

        

        public Vendedor() { }

        public Vendedor(int id, string nome, string email, DateTime dataDeNascimento, double salarioBase, Department departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataDeNascimento = dataDeNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVenda(Vendas vd)
        {
            Vendas.Add(vd);
        }

        public void RemoverVenda(Vendas vd)
        {
            Vendas.Remove(vd);
        }

        public double VendasTotais(DateTime inicial, DateTime final)
        {
            return Vendas.Where(vd => vd.Data >= inicial && vd.Data <= final).Sum(vd => vd.Quantidade);

        }
    }
}
