using reacttestapp.Models;

namespace reactApp.Models.Positions
{
    public class RunningBack : Player, IFlex
    {
        public bool CanFlex { get; set; }

        public RunningBack(
            string name, string position, string id, int proj, int salary) 
            : base(name, position, id, proj, salary)
        {
            this.CanFlex = true;
        }
    }
}
