using System.ComponentModel.DataAnnotations;

namespace BlaisePascal.LessonsExamples.Domain
{
    public class Enemy
    {
        //attribute
        private int _health;

        public int Health { get; private set; }

        //costruttore
        public Enemy()
        {
        }


        public void setHealth(int newHealth)
        {
            if (newHealth < 0)
                _health = 0;
            else if (newHealth > 100)
                _health = 100;
            else
                _health = newHealth;

        }

        public bool isAlive()
        {
            return _health > 0;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                damage = 0;
            setHealth(_health - damage);
        }
    }
}
