﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class TV
    {
        public abstract void on();
        public abstract void off();
        public abstract void tuneChannel(int  channel);
        public abstract int getChannel();
    }
}
