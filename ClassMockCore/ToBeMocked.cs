using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMockCore
{
    public class ToBeMocked
    {
        public virtual int TwoTimes(int number) => number * 2;
    }
}
