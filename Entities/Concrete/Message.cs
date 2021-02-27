using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("Message")]
    public class Message:IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        [Display(Name = "Message Content")]
        public string MessageContent { get; set; }
        public DateTime MessageTime { get; set; }

        public ICollection<UserMessage> UserMessages { get; set; }


    }
}
