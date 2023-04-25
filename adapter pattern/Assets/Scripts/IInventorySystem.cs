using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this tells us how we wished  the original class worked
// these methods are how we  wish the original class was set up
public interface IInventorySystem 
{
    void SyncInventories();

    void AddItem(InventoryItem anItem, SaveLocation aLocation);

    void RemoveItem(InventoryItem anItem, SaveLocation aLocation);
    
    public List<InventoryItem> GetInventory(SaveLocation aLocation);
}


// save data in cvs and in json