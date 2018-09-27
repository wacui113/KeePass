using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeePass
{
    [Serializable]
    public class KeePassData
    {
        private List<KeePass> listdata;

        public List<KeePass> Listdata
        {
            get
            {
                return listdata;
            }

            set
            {
                listdata = value;
            }
        }
    }
}
