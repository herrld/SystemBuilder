using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBuilderDataModels
{
    public class NodeType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Node> Nodes { get; set; }
    }
}
