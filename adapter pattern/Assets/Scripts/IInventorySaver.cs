using UnityEngine;
using System.Collections.Generic;
using System.IO;

public interface IInventorySaver
{
    void SaveInventoryItems(List<InventoryItem> inventoryItems);
}