﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBuilderDataModels.Fields
{
    public class TextField : Field
    {
        public string Value { get; set; }

        public int Length { get; set; }
    }
}
