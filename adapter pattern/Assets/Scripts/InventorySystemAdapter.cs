using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystemAdapter : InventorySystem, IInventorySystem
{
    private List<InventoryItem> cloudInventory;
   
    public void SyncInventories()
    {
        var cloudInventory = GetInventory();
        Debug.Log("Downloading the cloud inventory");
    }

    public void AddItem(InventoryItem anItem, SaveLocation aLocation)
    {
        if(aLocation == SaveLocation.Cloud)
        {
           AddItem(anItem);
        }
        
        if(aLocation == SaveLocation.Local)
        {
            Debug.Log("We need to code here to save item to local drive");
        }

        if (aLocation == SaveLocation.Both)
        {
            AddItem(anItem);
            Debug.Log("We need to code here to save item to local drive");
        }
    }

    public void RemoveItem(InventoryItem anItem, SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
            RemoveItem(anItem);
        }

        if (aLocation == SaveLocation.Local)
        {
            Debug.Log("We need to code here to save item from local drive");
        }

        if (aLocation == SaveLocation.Both)
        {
            RemoveItem(anItem);
            Debug.Log("We need to code here to save item from local drive");
        }
    }

    public List<InventoryItem> GetInventory(SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
            GetInventory();
        }

        if (aLocation == SaveLocation.Local)
        {
            Debug.Log("We need to code here to get inventory from local drive");
        }

        if (aLocation == SaveLocation.Both)
        {
            GetInventory();
            Debug.Log("We need to code here to get inventory from local drive");
        }

        //this is fake return this doesnot do anything useful in actual rn
        //It is a faux return statement

        //fix this in you code  assignment because this doesnot do anything useful in actual rn
        return new List<InventoryItem>();
    }

}
