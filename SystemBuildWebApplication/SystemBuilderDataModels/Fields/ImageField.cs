using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBuilderDataModels.Fields
{
    public class ImageField : FieldInstance
    {
        public string FileName { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }
    }
}
