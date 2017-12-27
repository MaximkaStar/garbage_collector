using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage_collector
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DeliveryDate { get; set; }
        private Guid ID { get; set; }
        public Item()
        {
            ID = Guid.NewGuid();
        }
    }
}
