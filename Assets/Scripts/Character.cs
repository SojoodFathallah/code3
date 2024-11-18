using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{

    private string name;

    public string Name{
        get{return name;}
        set{name = value;}
    }

    public int health;

    public int Health{
        get{return health;}
        set{health = value;}
    }

    public Character(string n, int h){
        Name = n;
        Health = h;
    }

    public void printInfo(){
        Debug.Log("name:" + Name + "health" + Health);
    }
   
}
