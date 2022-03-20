using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Assignment_Serilization
{
    [Serializable]
    public class Product
    {
        public int Pcode { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }

    }
}
