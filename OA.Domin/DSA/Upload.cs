using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domin.DSA
{
    public class Upload : BaseEntity
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public string Extention { get; set; }

        public string Path { get; set; }

        public string URL { get; set; }

        public string Type { get; set; }

        public string Order { get; set; }

        public int ReferenceId { get; set; }

        public string Reference { get; set; }

    }
}
