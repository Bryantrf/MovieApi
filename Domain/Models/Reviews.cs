using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
	public class Reviews
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Review { get; set; } = string.Empty;
        public int MovieId { get; set; }
        public bool Cancelled { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

