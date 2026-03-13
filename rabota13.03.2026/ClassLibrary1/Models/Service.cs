using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Service
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Dictionary<string, int> DailyStats { get; set; }

        public Service()
        {
            DailyStats = new Dictionary<string, int>();
        }
    }
}
