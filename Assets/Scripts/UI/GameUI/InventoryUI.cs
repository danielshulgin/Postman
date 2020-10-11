using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private void Awake()
    {
        PlayerInventory.OnUpdate += HandleUpdateInventory;
    }

    private void OnDestroy()
    {
        PlayerInventory.OnUpdate -= HandleUpdateInventory;
    }

    private void HandleUpdateInventory(IReadOnlyCollection<Item> inventoryItems)
    {
        
    }
}
