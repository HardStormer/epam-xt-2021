using System;
using System.Collections.Generic;

namespace GMD.THREE_LAYER.Entities
{
    public class Award
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public List<Guid> Users { get; set; }
    }
}
