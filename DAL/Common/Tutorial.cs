using System;
using System.Collections.Generic;
using System.Linq;

namespace Code2Night.DAL.Common
{
    public class Tutorial
    {
        public object Id { get; set; }

        public string TopicName { get; set; }
        public string Technology { get; set; }
        public Users user { get; set; }

        public DateTime Topicdate { get; set; }
    }
}