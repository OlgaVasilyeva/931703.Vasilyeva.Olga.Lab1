using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend1.Services
{
    public class ArithmetService : IArithmetService
    {
        public int plus(int a, int b)
        {
                int c = a + b;
                return c;
        }
        
        public int del(int a, int b)
        {
                int c = a / b;
                return c; 
        }  

        public int minus(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public int sum(int a, int b)
        {
            int c = a * b;
            return c;
        }
    }
}
