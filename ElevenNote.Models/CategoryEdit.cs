using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class CategoryEdit
    {
        public int CategoryId { get; set; }
        public string CatName { get; set; }

        [ForeignKey("Note")]
        public int NoteId { get; set; }
    }
}
