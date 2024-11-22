using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Character1
    {
        public string name;
        private int health;
        protected Position position;

        public int Health
        {
            get { return health; }
            set
            {
                if (health < 0)
                {
                    health = 0;
                }
                else if (health > 100)
                {
                    health = 100;
                }
                else health = value;
            }
        }

        public Character1(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }

        public Character1() : this("", 100, new Position(0, 0, 0))
        {

        }

        public virtual void DisplayInfo()
        {
            Debug.Log("Name is :" + name);
            Debug.Log("Health is :" + health);
            position.PrintPosition();
        }

        public void Attack(int damage, Character1 target)
        {
            target.health = target.health - damage;
            Debug.Log("Health after attack : " + health);
        }

        public void Attack(int damage, Character1 target, string attackType)
        {
            Attack(damage, target);
            Debug.Log("Attack type is : " + attackType);


        }







    }


}



