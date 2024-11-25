using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<string> names = new List<string>();

    public void AddItem(string item)
    {
        names.Add(item);
    }

    public void ShowItems()
    {
        for (int i = 0; i < names.Count; i++)
        {
            Debug.Log(names[i]);
        }
    }

    public static Inventory operator +(Inventory one, Inventory two)
    {
        Inventory three = new Inventory();

        for (int i = 0; i < one.names.Count; i++)
        {
            three.AddItem(one.names[i]);
        }

        for (int i = 0; i < two.names.Count; i++)
        {
            three.AddItem(two.names[i]);
        }
        return three;

    }
}
