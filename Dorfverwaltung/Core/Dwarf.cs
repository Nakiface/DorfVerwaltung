using System.Collections.Generic;
using System.Linq;

namespace Dorfverwaltung
{
    public interface ITribeMember
    {
        string Name { get; set; }
    }
    public class Dwarf
    {
        public string Name { get; set; }
        public int Alter { get; set; }
        public int Macht =>
            Waffen.Aggregate(0, (a, item) => a + item.Macht);
        public List<Weapon> Waffen { get; set; }

        public Dwarf(string name, int age, List<Weapon> weaponList = null)
        {
            this.Name = name;
            this.Alter = age;
            this.Waffen = weaponList;
        }

        public void addWeapon(Weapon weapon)
        {
            Waffen.Add(weapon);
        }

        public void removeWeapon(Weapon weapon)
        {
            Waffen.Remove(weapon);
        }
    }
}
