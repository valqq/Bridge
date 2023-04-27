using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TVFactory
    {
        public TV getTV(String type)
        {
            if (type.Equals("LG"))
            {
                return new LG();
            }
            else if (type.Equals("Sony"))
            {
                return new Sony();
            }
            else
            {
                throw new Exception("INvalid TV type");
            }
        }
    }
}
