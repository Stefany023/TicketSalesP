using System.ComponentModel.DataAnnotations;
using TicketSalesP.Data.Entities;

namespace TicketSalesP.Models
{
    public class TicketViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Estado de la boleta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public bool WasUsed { get; set; }


        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string Document { get; set; }

        [Display(Name = "Nombre Completo")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public string name { get; set; }

        public Entrance Entrance { get; set; }

        [Display(Name = "Fecha y hora")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        public DateTime? Date { get; set; }
    }
}
