using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBuilderDataModels
{
    public class FieldType
    {
        public enum FieldTypes { wholeNumber=1, decimalNumber, text, image};

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
