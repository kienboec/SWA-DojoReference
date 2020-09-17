using MessageBar.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MessageBar.Model
{
    public class Message
    {
      

        public string Text { get; set; }
        public MessageState State { get; set; }

        public Message(string text, MessageState state)
        {
            Text = text;
            State = state;
        }
    }
}
