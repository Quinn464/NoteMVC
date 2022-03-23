using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryCreate
    {
        [Required]
        [Display(Name = "Category")]
        [MinLength(3, ErrorMessage = "Category name is too short. Please enter at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "Category name is too long. Please enter at max 50 characters.")]
        public string CatName { get; set; }

        [ForeignKey("Note")]
        [Required]
        public int NoteId { get; set; }

        public IEnumerable<NoteListItem> Notes { get; set; }

    }
}
