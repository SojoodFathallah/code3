using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Player mamdoo7 = new Player("mamdoo7", 85);
    Enemy med7at = new Enemy("med7at", 60);

    void start()
    {

        mamdoo7.printInfo();
        med7at.printInfo();

        mamdoo7.Heal(10);
        med7at.Attack(5);

        mamdoo7.printInfo();
        med7at.printInfo();

    }



}
