using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientAdapter : MonoBehaviour
{
    public InventoryItem item;
    private InventorySystem inventorySystem;
    private IInventorySystem inventorySystemAdapter;

    // Start is called before the first frame update
    void Start()
    {
        inventorySystem = new InventorySystem();
        inventorySystemAdapter = new InventorySystemAdapter();
    }

    // Update is called once per frameic
    void OnGUI()
    {
        if (GUILayout.Button("Add item(no adaptor"))
        {
            inventorySystem.AddItem(item);
        }
        if (GUILayout.Button("Add item(no adaptor"))
        {
            inventorySystemAdapter.AddItem(item,SaveLocation.Both);
        }
    }
}
