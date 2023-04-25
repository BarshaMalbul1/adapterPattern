using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class JsonInventorySaver : IInventorySaver
{
    public void SaveInventoryItems(List<InventoryItem> inventoryItems)
    {
        // Convert inventory items to JSON string
        string json = ConvertInventoryItemsToJSON(inventoryItems);

        // Save JSON string to file
        File.WriteAllText(@"C:\Users\barsh\Documents\oop\inventory.json", json);

        Debug.Log("Inventory items saved as JSON.");
    }

    private string ConvertInventoryItemsToJSON(List<InventoryItem> inventoryItems)
    {
        // Convert inventory items to JSON using Unity's built-in JsonUtility
        string json = JsonUtility.ToJson(new InventoryItemList(inventoryItems), true);

        return json;
    }
}
