namespace DPINT_Wk2_Decorator.Model
{
    public class ShotgunFighterDecorator : BaseFighterDecorator
    {
        public int ShotgunRoundsFired { get; set; }

        public ShotgunFighterDecorator(IFighter fighter) : base(fighter)
        {
            ShotgunRoundsFired = 0;
        }

        public override Attack Attack()
        {
            var attack = Fighter.Attack();
            if (ShotgunRoundsFired < 2)
            {
                attack.Messages.Add("Shotgun: 20");
                attack.Value += 20;
                ShotgunRoundsFired++;
            }
            else
            {
                attack.Messages.Add("Shotgun reloading, no extra damage.");
                ShotgunRoundsFired = 0;
            }
            return attack;
        }
    }
}