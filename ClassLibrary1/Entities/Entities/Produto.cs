using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Produto")]
    public class Produto : Notifies
    {
        [Column("IdProduto")]
        [Display(Name = "IdProduto")]
        public int IdProduto { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string NomeProduto { get; set; }

        [Column("Valor")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }
    }
}
