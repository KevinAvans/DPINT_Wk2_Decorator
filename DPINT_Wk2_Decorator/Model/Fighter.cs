using System;

namespace DPINT_Wk2_Decorator.Model
{
    public class Fighter : IFighter
    {
        public int Lives { get; set; }
        public int AttackValue { get; set; }
        public int DefenseValue { get; set; }

        public Fighter(int lives, int attack, int defense)
        {
            Lives = lives;
            AttackValue = attack;
            DefenseValue = defense;
        }

        public void Defend(Attack attack)
        {
            var hit = Math.Max(0, attack.Value - DefenseValue);
            Lives -= hit;
            attack.Messages.Add($"Attacked: {attack.Value}, Defended: {DefenseValue}, got hit: {hit}");
        }

        public Attack Attack()
        {
            var attack = new Attack("Normal attack: " + AttackValue, AttackValue);
            return attack;
        }
    }
}
