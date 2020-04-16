using System;
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

        public static List<Tribe> RemoveDataFromList(Object context, List<Tribe> tribeList, string name)
        {
            if (context is Tribe tribeData)
            {
                tribeList.Remove(GetTribeByName(tribeList, name));
            }
            if (context is Dwarf dwarfData)
            {
                var selectedTribe = FindTribeByDwarf(tribeList, GetDwarfByName(tribeList, name));
                selectedTribe.removeDwarf(GetDwarfByName(tribeList, name));
            }
            if (context is Weapon weaponData)
            {
                RemoveWeaponByName(tribeList, name);
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

        public static List<string> FindAllWeaponsWithDwarfName(List<Dwarf> dwarfList)
        {
            List<string> result = new List<string>();
            string dwarfName = "";
            string weaponName = "";

            foreach (var dwarf in dwarfList)
            {
                dwarfName = dwarf.Name;
                foreach (var weapon in dwarf.Waffen)
                {
                    weaponName = weapon.Typ;
                    result.Add($"{weaponName} ({dwarfName})");
                }
            }
            return result;
        }

        public static Tribe FindTribeByDwarf(List<Tribe> tribeList, Dwarf dwarf)
        {
            foreach (var tribe in tribeList)
            {
                if (tribe.Zwerge.Select(d => d).Where(x => x == dwarf).Count() > 0)
                    return tribe;
            }
            return null;        
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

        public static void RemoveWeaponByName(List<Tribe> tribeList, string name)
        {
            var weaponDwarf = name.Split(' ');
            var dwarfName = weaponDwarf[1].Trim('(', ')', ' ');
            var weaponName = weaponDwarf[0];
            var dwarf = GetDwarfByName(tribeList, dwarfName);
            dwarf.removeWeapon(dwarf.Waffen.Where(w => w.Typ == weaponName).FirstOrDefault());
        }
    }
}
