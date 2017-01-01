using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBuilderDataModels.Fields
{
    public class NumberField : Field
    {
        public int Value { get; set; }

        public int MaxValue { get; set; }

        public int MinValue { get; set; }
    }
}
