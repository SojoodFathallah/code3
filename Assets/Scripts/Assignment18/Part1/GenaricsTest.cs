using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GenaricsTest : MonoBehaviour
{

    void Start()
    {
        GameContainer<string> item = new GameContainer<string>("Healing Potion");
        Debug.Log(item.GetItem());

        string description = GameUtils.DescribeItem<string>(item.GetItem());
        Debug.Log(description);


    }


}
