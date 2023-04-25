using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class InventoryItemList
{
    public List<InventoryItem> InventoryItems;

    public InventoryItemList(List<InventoryItem> items)
    {
        InventoryItems = items;
    }
}
