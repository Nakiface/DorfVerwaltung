namespace Dorfverwaltung
{
    public class Weapon
    {
        public string Typ { get; set; }
        public int Macht { get; set; }

        public Weapon(string type = "", int force = 0)
        {
            this.Typ = type;
            this.Macht = force;
        }
    }
}
