using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Day_29___Identity_Framework.Models
{
    public class Presidents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PresidentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Terms { get; set; }

        [Required]
        public DateTime InaugurationDate { get; set; }

        public Presidents() { 
        }

        public Presidents(int id, string name, int terms, DateTime inaugurationdate)
        {
            PresidentId = id;
            Name = name;
            Terms = terms;
            InaugurationDate = inaugurationdate;
        }
    }
}
