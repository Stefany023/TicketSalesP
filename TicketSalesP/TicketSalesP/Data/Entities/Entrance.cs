using System.ComponentModel.DataAnnotations;

namespace TicketSalesP.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }

        [Display(Name = "Localidad de la boleta ")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string Description { get; set; }

        public ICollection<Ticket> Tickets { get; set; }


        //[Display(Name = "Tiketes")]
        //public int TicketsNumber => Tickets == null ? 0 : Tickets.Count;
    }
}
