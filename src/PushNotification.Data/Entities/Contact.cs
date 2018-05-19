using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PushNotification.Models
{
    public class Contact
    {

        public Contact()
        {
            this.AddedOn = DateTime.Now;
        }

        [Key]
        public int ContactID { get; set; }

        [MaxLength(40, ErrorMessage = "Tamanho máximo de {0} é {1}")]
        [Display(Name = "Nome do Contato")]
        [Required(ErrorMessage = "Campo Nome é obrigatório!")]
        public string ContactName { get; set; }

        [MaxLength(8, ErrorMessage = "Tamanho máximo de {0} é {1}")]
        [Display(Name = "Nº do Contato")]
        [Required(ErrorMessage = "Campo Nº do Contato é obrigatório!")]
        public string ContactNo { get; set; }

        [Display(Name = "Data da Inserção")]
        public DateTime AddedOn { get; set; }

    }
}