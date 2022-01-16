namespace Estoque.DOMAIN.Models
{
    public class RegistroDano
    {
        public int Id { get; set; }
        //public int FuncionarioId { get; set; }
        //public Funcionario Funcionario { get; set; }
        public virtual ICollection<ItemDanificado> Danificados { get; set; }
        public DateTime DataDeRegistro { get; set; }
    }
}
