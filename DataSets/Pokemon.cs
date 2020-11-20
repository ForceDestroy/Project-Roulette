using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Roulette.DataSets
{
    class Pokemon
    {
        public int id { get; set; }
        public string nameEng { get; set; }
        public string type1 { get; set; }
        public string type2 { get; set; }

        public Pokemon()
        {
            this.id = 0;
            this.nameEng = null;
            this.type1 = null;
            this.type2 = null;
        }

        public Pokemon(int id, string nameEng, string type1, string type2)
        {
            this.id = id;
            this.nameEng = nameEng;
            this.type1 = type1;
            this.type2 = type2;
        }
    }
}
