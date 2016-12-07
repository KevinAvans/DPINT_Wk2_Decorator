using System;

namespace DPINT_Wk2_Decorator.Model
{
    public class MinionFighterDecorator : BaseFighterDecorator
    {
        public int MinionLives { get; set; }
        public int MinionAttackValue { get; set; }

        public MinionFighterDecorator(IFighter fighter, int lives, int attack) : base(fighter)
        {
            MinionLives = lives;
            MinionAttackValue = attack;
        }

        public override void Defend(Attack attack)
        {
            if (MinionLives > 0)
            {
                var tmpLives = MinionLives;
                MinionLives -= Math.Max(0, attack.Value);
                attack.Value -= Math.Max(0, tmpLives - MinionLives);
                attack.Messages.Add("Minion defended from the attack: -" + attack.Value);
            }
            Fighter.Defend(attack);
        }

        public override Attack Attack()
        {
            var attack = Fighter.Attack();
            if (MinionLives <= 0) return attack;
            attack.Messages.Add("Minion helping the attack: " + MinionAttackValue);
            attack.Value += MinionAttackValue;
            return attack;
        }
    }
}