using System;
using System.Collections.Generic;
using System.Text;

namespace Forum
{
    public class Thread
    {
        public int TreahId { get; set; }
        public string Topic { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public int PostCount { get; set; }
    }
}
