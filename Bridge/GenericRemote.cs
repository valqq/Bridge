using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Bridge
{
    public class GenericRemote : RemoteControl
    {
        public GenericRemote(TVFactory tvFactory) : base(tvFactory)
        {
        }

        public void nextChannel()
        {
            int channel = this.getChannel();
            setChannel(channel + 1);

        }
        public void prevChannel()
        {
            int channel = this.getChannel();
            this.setChannel(channel - 1);
        }
    }

}
