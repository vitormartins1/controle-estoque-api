namespace Estoque.DOMAIN.Models
{
    public class RegistroSaida 
    {
        public int Id { get; set; }
        public DateTime DataDeRegistro { get; set; }
        //public int FuncionarioId { get; set; }
        //public Funcionario Funcionario { get; set; }
        public virtual ICollection<Item> Itens { get; set; }
    }
}
