using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private List<InventoryItem> inventoryItems = new List<InventoryItem>();

    private IInventorySaver inventorySaver;

    void Start()
    {
        // Choose whether to save as CSV or JSON based on a condition
        if (inventorySaver == null)
        {
            inventorySaver = new CsvInventorySaver();
        }
        else
        {
            inventorySaver = new JsonInventorySaver();
        }

        // Save inventory items using the selected inventory saver
        inventorySaver.SaveInventoryItems(inventoryItems);
    }
}
