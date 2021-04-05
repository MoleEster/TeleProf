using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APCTest.Classes
{
    class City
    {
        private int c_id;
        private string c_name;
        
        public City(string name)
        {
            c_name = name;
            Counter.Hit();
            c_id = Counter.i;
        }

        public string GetName() => c_name;
        public int GetId() => c_id;
    }
}
