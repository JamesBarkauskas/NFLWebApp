using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NFLWebApp.Models
{
    public class WideReceiver
    {
        public int ID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Team { get; set; }
        [Required]
        public int Touchdowns { get; set; }
        [Required]
        public int Yards { get; set; }
    }
}
