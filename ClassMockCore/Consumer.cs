using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMockCore
{
    public class Consumer 
    {
        public string StrTwoTimes(int number)
        {
            ToBeMocked toBeMocked = Locator.GetToBeMocked();
            return (toBeMocked.TwoTimes(number)).ToString();
        }
    }
}
