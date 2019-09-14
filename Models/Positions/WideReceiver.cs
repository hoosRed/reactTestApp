using reacttestapp.Models;

namespace reactApp.Models.Positions
{
    public class WideReceiver : Player, IFlex
    {
        public bool CanFlex { get; set; }

        public WideReceiver(
            string name, string position, string id, int proj, int salary)
            : base(name, position, id, proj, salary)
        {
            this.CanFlex = true;
        }
    }
}
