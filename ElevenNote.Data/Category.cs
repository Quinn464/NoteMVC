using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string CatName { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }

        [ForeignKey(nameof(Note))]
        public int NoteId { get; set; }
        public virtual Note Note { get; set; }

        public virtual ICollection<Note> Notes { get; set; }

    }
}
