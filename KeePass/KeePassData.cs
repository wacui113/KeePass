using System;
using System.Collections;
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

        public string SetID()
        {
            uint run = 0;
            if(listdata.Count <= 0)
            {
                return run.ToString();
            }
            
            foreach(KeePass item in listdata)
            {
                if(Convert.ToUInt32(item.Id) != run)
                {
                    break;
                }
                run++;
            }
            return run.ToString();
        }

        public static void RemoveKP(object id)
        {
            KeePass kp;
            /* Tìm kiếm theo Id KeePass 
             * (https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=netframework-4.7.2) */
            kp = FormMain.Data.listdata.Find(x => x.Id == id.ToString());
            int index = FormMain.Data.listdata.IndexOf(kp);
            FormMain.Data.listdata.RemoveAt(index);
        }
    }

    public class sortKeePass : IComparer<KeePass>
    {
        public int Compare(KeePass x, KeePass y)
        {
            KeePass kp1 = x as KeePass;
            KeePass kp2 = y as KeePass;

            if (Convert.ToUInt32(kp1.Id) > Convert.ToUInt32(kp2.Id))
            {
                return 1;
            }
            if (Convert.ToUInt32(kp1.Id) < Convert.ToUInt32(kp2.Id))
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
