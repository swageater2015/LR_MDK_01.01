using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_3__variant_3_
{
    public class Filmes
    {
        public int cost_;
        public string director_;
        public string roles_;
        public int date_;

        public Filmes(int cost, string director, string roles, int date)
        {
            cost_ = cost;
            director_ = director;
            roles_ = roles;
            date_ = date;
        }

    }
}
