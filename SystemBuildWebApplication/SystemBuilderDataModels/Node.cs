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
        public int Id { get; set; }

        public int NodeTypeId { get; set; }

        public NodeType NodeType { get; set; }

        public virtual ICollection<FieldInstance> Fields { get; set; }

        public UserInterface UI { get; set; }
    }
}
