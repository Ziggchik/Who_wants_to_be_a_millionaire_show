using System.ComponentModel.DataAnnotations.Schema;

namespace Who_wants_to_be_a_millionaire_show.Models
{
    [Table("Answer")]
    public partial class Answer
    {
        public int IdAnswer { get; set; }
        public string Content { get; set; }
        public bool? Correct { get; set; }
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }
    }
}
