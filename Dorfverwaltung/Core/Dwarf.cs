using System.Collections.Generic;
using System.Linq;

namespace Dorfverwaltung
{
    public interface ITribeMember
    {
        string Name { get; set; }
        int Alter { get; set; }
    }
    public class Dwarf : ITribeMember
    {
        public string Name { get; set; } 
        public int Alter { get; set; }
        public int Macht =>
            Waffen?.Aggregate(0, (a, item) => a + item.Macht) ?? 0;
        public List<Weapon> Waffen { get; set; } = new List<Weapon>();

        public Dwarf(string name, int age, List<Weapon> weaponList)
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
