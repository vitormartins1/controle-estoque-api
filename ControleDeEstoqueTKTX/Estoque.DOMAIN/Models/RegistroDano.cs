namespace Estoque.DOMAIN.Models
{
    public class RegistroDano : Registro
    {
        public virtual ICollection<ItemDanificado> Danificados { get; set; }
    }
}
