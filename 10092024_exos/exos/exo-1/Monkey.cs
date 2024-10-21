using System;
using System.Collections.Generic;

namespace Circus
{
    public abstract class Monkey
    {
        protected List<string>    trickList;

        protected Monkey(List<string> trickList)
        {
            this.trickList = trickList;
        }

        public abstract int doATrick();
    }
}
