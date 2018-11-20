using System;
using System.Collections.Generic;

namespace CottonCompany.Model
{
    public partial class NFilter
    {
        public int Filterid { get; set; }
        public string Filtername { get; set; }
        public string Filtertype { get; set; }
        public string Linkedtable { get; set; }
        public string LinkedfieldGetvalue { get; set; }
        public string LinkedfieldToshow { get; set; }
        public int Sequence { get; set; }
    }
}
