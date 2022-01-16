using Estoque.DOMAIN.Enums;

namespace Estoque.DOMAIN.Diagrams
{
    public class ItemVendaTeste : Item
    {
        //public int Id { get; set; }
        public int VendaTesteId { get; set; }

        public ItemVendaTeste()
        {
            Tipo = TipoItem.SAIDA;
        }
    }
}
