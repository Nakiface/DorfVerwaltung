using System.Collections.Generic;
using System.Linq;

namespace Dorfverwaltung
{
    public class Tribe
    {
        public string Name { get; set; }
        public int Gründung { get; set; }
        public int Macht =>
            Zwerge.Aggregate(0, (a, dwarf) => a + dwarf.Macht);
        public List<Dwarf> Zwerge { get; set; }
        public string leader { get; set; }
        public int Führer_seid { get; set; }

        public Tribe(string name, int founding, List<Dwarf> dwarfList = null, Dwarf leader = null, int leadsince = 0)
        {
            this.Name = name;
            this.Gründung = founding;
            this.Zwerge = dwarfList;
            this.leader = leader?.Name;
            this.Führer_seid = leadsince;
        }

        public void addDwarf(Dwarf dwarf)
        {
            Zwerge.Add(dwarf);
        }

        public void removeDwarf(Dwarf dwarf)
        {
            Zwerge.Remove(dwarf);
        }

        public bool setLeader(Dwarf dwarf, int leadsince)
        {
            if (!(this.Führer_seid != 0 && this.Führer_seid > leadsince))
                this.Führer_seid = leadsince;
            else
                return false;

            if (Zwerge.Contains(dwarf))
                this.leader = dwarf.Name;
            else
                return false;

            return true;
        }
    }
}
