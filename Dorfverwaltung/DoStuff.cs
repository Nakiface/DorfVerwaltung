using System.Collections.Generic;
using System.Windows.Forms;

namespace Dorfverwaltung
{
    public static class DoStuff
    {
        public static List<Tribe> AddStuff(BindingSource bindingSource, List<Tribe> tribeList)
        {
            if (bindingSource.DataSource is Tribe tribeData)
            {
                tribeList.Add(tribeData);
                return tribeList;
            }
            return null;
        }
    }
}
