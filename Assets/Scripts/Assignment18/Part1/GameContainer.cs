using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GameContainer<T>
{
    public T item;

    public GameContainer(T item)
    {
        this.item = item;
    }

    public void SetItem(T items)
    {
        item = items;
    }
    public T GetItem()
    {
        return item;
    }


}
