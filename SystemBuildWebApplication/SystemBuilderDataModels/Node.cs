using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBuilderDataModels.Fields;

namespace SystemBuilderDataModels
{
    public class Node
    {
        public Node()
        {
            this.init();
        }
        public int Id { get; set; }

        public int NodeTypeId { get; set; }

        public NodeType NodeType { get; set; }

        public List<TextField> TextFields { get; set; }

        public List<NumberField> WholeNumbers { get; set; }

        public List<ImageField> Images { get; set; }

        public UserInterface UI { get; set; }

        public bool IsPrototypeNode { get; set; }

        public int? PrototypeNodeId { get; set; }

        public Node PrototypeNode { get; set; }

        private void init()
        {
            this.TextFields = new List<TextField>();
            this.WholeNumbers = new List<NumberField>();
            this.Images = new List<ImageField>();
        }
    }
}
