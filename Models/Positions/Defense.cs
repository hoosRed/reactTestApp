using reacttestapp.Models;

namespace reactApp.Models.Positions
{
    public class Defense : Player
    {
        public Defense(string name, string position, string id, int proj, int salary)
            : base(name, position, id, proj, salary)
        {
        }
    }
}
