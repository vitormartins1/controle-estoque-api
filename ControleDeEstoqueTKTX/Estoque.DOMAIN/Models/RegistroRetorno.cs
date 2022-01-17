namespace Estoque.DOMAIN.Models
{
    public class RegistroRetorno : Registro
    {
        public virtual ICollection<ItemRetornado> Retornados { get; set; }
    }
}
