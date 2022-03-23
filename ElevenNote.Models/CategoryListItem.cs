using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryListItem
    {
        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        public string CatName { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [ForeignKey("Note")]
        public int NoteId { get; set; }
    }
}
