using System;
using System.Collections.Generic;
using System.Text;

namespace Forum
{
    class Post
    {
        public int PostId { get; }
        public string Text { get; set; }
        public string UserId { get; set; }
        public string TreadId { get; set; }
        public string Date { get; set; }
        public User User { get; set; }
        public Thread Tread { get; set; }
    }
}
