using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RemoteControl
    {
        TV tv;
        TVFactory tvFactory;

        public RemoteControl(TVFactory tvFactory)
        {

            this.tvFactory = tvFactory;
        }

        public void on()
        {
            tv.on();
        }

        public void off() 
        { 
            tv.off(); 
        }

        public int getChannel()
        {
            return tv.getChannel();
        }

        public void setTV(string type)
        {
            try
            {
                tv = tvFactory.getTV(type);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void setChannel(int channel)
        {
            tv.tuneChannel(channel);
        }
    }
}