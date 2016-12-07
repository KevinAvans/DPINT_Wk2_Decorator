using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model
{
    public class StrenghtenFighterDecorator : BaseFighterDecorator
    {
        public StrenghtenFighterDecorator(IFighter fighter) : base(fighter)
        {
            fighter.DefenseValue += fighter.DefenseValue / 10;
            fighter.AttackValue += fighter.AttackValue / 10;
        }

    }
}
