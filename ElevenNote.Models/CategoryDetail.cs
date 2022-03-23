using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }

        [Display(Name = "Category")]
        public string CatName { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUTc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUTc { get; set; }

        [ForeignKey("Note")]
        public int NoteId { get; set; }

    }
}
