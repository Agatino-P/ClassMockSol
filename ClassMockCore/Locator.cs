using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMockCore
{
    public static class Locator
    {
        public static Func<ToBeMocked> GetToBeMocked { get; set; } = (() => new ToBeMocked());
    }
}
