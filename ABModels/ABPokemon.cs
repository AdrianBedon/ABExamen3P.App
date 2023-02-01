using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABExamen3P.ABModels
{
    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Root
    {
        public int count { get; set; }
        public object next { get; set; }
        public object previous { get; set; }
        public List<Pokemon> results { get; set; }
    }

}
