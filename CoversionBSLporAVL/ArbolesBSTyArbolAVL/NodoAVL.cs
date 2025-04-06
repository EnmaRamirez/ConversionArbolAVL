using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolesBSTyArbolAVL
{
    public class NodoAVL
    {
        public int data;
        public NodoAVL left;
        public NodoAVL right;
        public int height;

        public NodoAVL(int data)
        {
            this.data = data;
            this.height = 1;
        }
    }
}
