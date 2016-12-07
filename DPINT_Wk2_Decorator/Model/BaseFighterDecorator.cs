namespace DPINT_Wk2_Decorator.Model
{
    public abstract class BaseFighterDecorator : IFighter
    {
        protected IFighter Fighter;

        public virtual int Lives {
            get { return Fighter.Lives; }
            set { Fighter.Lives = value; }
        }

        public virtual int AttackValue {
            get { return Fighter.AttackValue; }
            set { Fighter.AttackValue = value; }
        }

        public virtual int DefenseValue {
            get { return Fighter.DefenseValue; }
            set { Fighter.DefenseValue = value; }
        }

        protected BaseFighterDecorator(IFighter fighter)
        {
            Fighter = fighter;
        }

        public virtual void Defend(Attack attack)
        {
            Fighter.Defend(attack);
        }

        public virtual Attack Attack()
        {
            return Fighter.Attack();
        }
    }
}