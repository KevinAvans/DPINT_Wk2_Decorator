namespace DPINT_Wk2_Decorator.Model
{
    public class PoisonFighterDecorator : BaseFighterDecorator
    {

        public int PoisonStrength { get; set; }

        public PoisonFighterDecorator(IFighter fighter, int strenght) : base(fighter)
        {
            PoisonStrength = strenght;
        }

        public override Attack Attack()
        {
            var attack = Fighter.Attack();
            if (PoisonStrength > 0)
            {
                attack.Messages.Add("Poison weakening, current value: " + PoisonStrength);
                attack.Value += PoisonStrength;
                PoisonStrength -= 2;
            }
            else
            {
                attack.Messages.Add("Poison ran out.");
            }
            return attack;
        }
    }
}