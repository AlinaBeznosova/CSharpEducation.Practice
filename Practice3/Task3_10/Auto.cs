using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_10
{
    class Auto
    {
        public string model;

        public Auto(string model)
        {
            this.model = model;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
    }
}
