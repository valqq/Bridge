using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SpecialRemote : RemoteControl
    {
        public SpecialRemote(TVFactory tvFactory) : base(tvFactory)
        {
        }

        public void up()
        {
            int channel = this.getChannel();
            setChannel(channel + 1);

        }
        public void down()
        {
            int channel = this.getChannel();
            this.setChannel(channel - 1);
        }
    }

}