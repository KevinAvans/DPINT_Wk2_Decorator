namespace DPINT_Wk2_Decorator.Model
{
    public class DoubleHandedFighterDecorator : BaseFighterDecorator
    {
        public DoubleHandedFighterDecorator(IFighter fighter) : base(fighter)
        {
        }

        public override void Defend(Attack attack)
        {
            attack.Messages.Add("One hand defended the attack: -" + DefenseValue);
            attack.Value -= DefenseValue;
            base.Defend(attack);
        }

        public override Attack Attack()
        {
            var attack = Fighter.Attack();
            attack.Value += AttackValue;
            attack.Messages.Add("Doubled the original attack value: " + AttackValue);
            return base.Attack();
        }
    }
}