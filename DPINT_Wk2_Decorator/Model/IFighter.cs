namespace DPINT_Wk2_Decorator.Model
{
    public interface IFighter
    {
        int Lives { get; set; }
        int AttackValue { get; set; }
        int DefenseValue { get; set; }

        void Defend(Attack attack);

        Attack Attack();
    }
}
