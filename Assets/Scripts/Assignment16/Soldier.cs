using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;

namespace Assignment18
{
    public class Soldier : Character1
    {
        public Soldier(string name1, int health1, Position position1) : base(name1, health1, position1)
        {
        }
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();

        }

    }
}