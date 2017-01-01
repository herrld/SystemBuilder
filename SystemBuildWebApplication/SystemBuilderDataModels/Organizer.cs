using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBuilderDataModels
{
    public class Organizer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Node> Nodes { get; set; }
    }
}
