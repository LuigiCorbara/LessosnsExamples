using System.ComponentModel.DataAnnotations;

namespace BlaisePascal.LessonsExamples.Domain
{
    public class Enemy
    {
        //attribute
        private int _health;

        public int Health { get; private set; }

        // property
        //public int Health 
        //{ 
        //    get { return _health; }
        //    set 
        //    {
        //        if (value < 0) //controllo 1
        //        {
        //            _health = 0;

        //        } else if (value > 100) // controllo 2
        //        {
        //            _health = 100;
        //        } else
        //        {
        //            _health = value; 
        //        }
        //    }
        //}

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
