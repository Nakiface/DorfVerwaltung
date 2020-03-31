using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dorfverwaltung
{
    public static class DoStuff
    {
        public static List<Tribe> AddDataToList(BindingSource bindingSource, List<Tribe> tribeList, string name)
        {
            if (bindingSource.DataSource is Tribe tribeData)
            {
                tribeList.Add(tribeData);
            }
            if (bindingSource.DataSource is Dwarf dwarfData)
            {
                GetTribeByName(tribeList, name).addDwarf(dwarfData);
            }
            if (bindingSource.DataSource is Weapon weaponData)
            {
                GetDwarfByName(tribeList, name).addWeapon(weaponData);
            }
            return tribeList;
        }

        public static List<string> FindAllDwarfNames(List<Tribe> tribeList)
        {
            var dwarfList = FindAllDwarfs(tribeList);
            return (dwarfList.Select(d => d.Name)).ToList();
        }

        public static List<Dwarf> FindAllDwarfs(List<Tribe> tribeList)
        {
            return (tribeList.SelectMany(t => t.Zwerge)).ToList();
        }

        public static List<string> FindAllTribeNames(List<Tribe> tribeList)
        {
            return (tribeList.Select(t => t.Name)).ToList();
        }

        public static Tribe GetTribeByName(List<Tribe> tribeList, string name)
        {
            return tribeList.Select(t => t).Where(tr => tr.Name == name).FirstOrDefault();
        }

        public static Dwarf GetDwarfByName(List<Tribe> tribeList, string name)
        {
            var dwarfList = FindAllDwarfs(tribeList);
            return dwarfList.Select(d => d).Where(dw => dw.Name == name).FirstOrDefault();
        }
    }
}
