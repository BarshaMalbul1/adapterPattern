using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class CsvInventorySaver : IInventorySaver
{
    public void SaveInventoryItems(List<InventoryItem> inventoryItems)
    {
        // Convert inventory items to CSV string
        string csv = ConvertInventoryItemsToCSV(inventoryItems);

        // Save CSV string to file
        File.WriteAllText(@"C:\inventory.csv", csv);

        Debug.Log("Inventory items saved as CSV.");
    }

    private string ConvertInventoryItemsToCSV(List<InventoryItem> inventoryItems)
    {
        string csv = "Item Name, Quantity\n"; // CSV header

        // Convert each inventory item to CSV format
        foreach (InventoryItem item in inventoryItems)
        {
            csv += item.ItemName + "," + item.Quantity + "\n";
        }

        return csv;
    }
}








