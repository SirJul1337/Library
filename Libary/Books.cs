using System;
using System.Collections.Generic;
using System.Text;

namespace Libary
{
    public class Books
    {
        private string name;
        private int refNum;
        private string color;
        private string gengre;
        public Books(string name, int refNum, string color, string gengre)
        {
            Name = name;
            ReferenceNumber = refNum;
            Color = color;
            Gengre = gengre;

        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ReferenceNumber
        {
            get { return refNum; }
            set { refNum = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Gengre
        {
            get { return gengre; }
            set { gengre = value; }
        }
        



    }


}
