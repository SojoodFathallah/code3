using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int health) : base(name,health){}

    public int Attack(int decrease){
        health = health - decrease;
        return health;
    }
}
