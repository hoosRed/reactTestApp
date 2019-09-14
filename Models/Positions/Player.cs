namespace reacttestapp.Models
{
    public abstract class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Id { get; set; }

        public int Projection { get; set; }
        public int Salary { get; set; }

        public Player(string name, string position, string id, int proj, int salary)
        {
            this.Name = name;
            this.Projection = proj;
            this.Salary = salary;
            this.Position = position;
            this.Id = id;
        }

        public override string ToString()
        {
            return this.Position + " :  " + this.Name + " : $" + this.Salary + " : " + this.Projection + "pts";
        }
    }
}
