namespace Estoque.DOMAIN.Models
{
    public class RegistroRetorno
    {
        public int Id { get; set; }
        //public int FuncionarioId { get; set; }
        //public Funcionario Funcionario { get; set; }
        public virtual ICollection<ItemRetornado> Retornados { get; set; }
        public DateTime DataDeRegistro { get; set; }
    }
}
