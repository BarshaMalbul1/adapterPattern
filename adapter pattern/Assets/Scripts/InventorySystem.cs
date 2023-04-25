using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem
{
    public void AddItem(InventoryItem anItem)
    {
        Debug.Log("Adding item to the cloud");
    }

    public void RemoveItem(InventoryItem anItem)
    {
        Debug.Log("removing item to the cloud");
    }

    public List<InventoryItem> GetInventory()
    {
        Debug.Log("getting items to the cloud");
        return new List<InventoryItem>();  
    }
}
