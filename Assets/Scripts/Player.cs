using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    public Player(string name, int health) : base(name,health){}

    public int Heal(int increase){

        Health = Health + increase;
        return Health;
   }

}