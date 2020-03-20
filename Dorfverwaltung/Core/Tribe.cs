namespace Dorfverwaltung
{
    public class Tribe
    {
        public string Name { get; set; }
        public int Gründung { get; set; }
        public int Macht =>
            dwarfList.Aggregate(0, (a, dwarf) => a + dwarf.Macht);
        public List<Dwarf> dwarfList { get; set; }
        public string leader { get; set; }
        public int Führer_seid { get; set; }

        public Tribe(string name, int founding, List<Dwarf> dwarfList = null, Dwarf leader = null, int leadsince = 0)
        {
            this.Name = name;
            this.Gründung = founding;
            this.dwarfList = dwarfList;
            this.leader = leader?.Name;
            this.Führer_seid = leadsince;
        }

        public void addDwarf(Dwarf dwarf)
        {
            dwarfList.Add(dwarf);
        }

        public void removeDwarf(Dwarf dwarf)
        {
            dwarfList.Remove(dwarf);
        }

        public bool setLeader(Dwarf dwarf, int leadsince)
        {
            if (!(this.Führer_seid != 0 && this.Führer_seid > leadsince))
                this.Führer_seid = leadsince;
            else
                return false;

            if (dwarfList.Contains(dwarf))
                this.leader = dwarf.Name;
            else
                return false;

            return true;
        }
    }
}
