using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

public class CharacterTest : MonoBehaviour
{
    Soldier soldier;
    Officer officer;
    Character1[] character = new Character1[2];
    void Start()
    {
        soldier = new Soldier("mamdoo7", 75, new Position(0, 0, 0));
        officer = new Officer("batreeq", 100, new Position(50, 40, 85));

        character[0] = soldier;
        character[1] = officer;

        for (int i = 0; i < character.Length; i++)
        {
            Character1 hello = character[i];
            hello.DisplayInfo();

        }

        officer.Attack(5, soldier, "stabbing");

    }


}
