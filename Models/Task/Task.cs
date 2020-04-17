using System;
using System.Collections.Generic;
using System.Text;

namespace Models.ModelTask
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string effort {get;set;}
        public string Status { get; set; }
        public int IdCollumn { get; set; }
    }
}
