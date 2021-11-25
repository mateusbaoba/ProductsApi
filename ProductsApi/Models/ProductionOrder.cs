using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsApi.Models
{
    [Table("ProductionOrder")]
    public class ProductionOrder
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public int OrderNumber { get; set; }
        public decimal QuantityRequired { get; set; }
        public decimal QuantityProduced { get; set; }
        public string ClientName { get; set; }
        public long ProductId { get; set; }
        public string MachineName { get; set; }
        /** Status de O.P.
         **0=bloqueado para produção;
         **1=liberado para produção;
         **2=em produção;
         **3=produção encerrada;
         **4=bloquado por inconsistência;
         **5=Ordem encerrada*/
        public OrderStatus Status { get; set; }
    }

    public enum OrderStatus { Boqueado, Liberado, Produzindo, Produzido, Bloqueado, Encerrado }
}
