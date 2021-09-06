using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Who_wants_to_be_a_millionaire_show.Models
{
    [Table("Question")]
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int IdQuestion { get; set; }
        public string Content { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
