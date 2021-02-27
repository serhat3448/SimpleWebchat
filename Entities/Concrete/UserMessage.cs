using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserMessage
    {
        public int UserId { get; set; }
        public User user { get; set; }
        public int MessageId { get; set; }
        public Message message { get; set; }
    }
}
