using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBuilderDataModels.Fields;

namespace SystemBuilderDataModels
{
    public class UserInterface
    {
        public int Id { get; set; }

        public int Name { get; set; }

        [Required]
        public Node Node { get; set; }

        public int NodeId { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}
