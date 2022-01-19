using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract_5
{
    class Pair
    {
        private int first;
        private int second;

        public int First
        {
            get { return first; }
        }

        public int Second
        {
            get { return second; }
        }

        public Pair(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        public int Sum()
        {
            return first + second;
        }

        public Pair Increase()
        {
            return new Pair(first + 1, second + 1);
        }

        public Pair SumPair(Pair pair)
        {
            return new Pair(first + pair.first, second + pair.second);
        }

        public Pair SumPair(Pair pair1, Pair pair2)
        {
            return new Pair(first + pair1.first + pair2.first, second + pair1.second + pair2.second);
        }
    }
}
