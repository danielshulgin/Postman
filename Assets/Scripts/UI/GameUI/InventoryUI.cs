using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private GameObject panelPrefab;
    [SerializeField] private GameObject cellPrefab;
    private Dictionary<string, GameObject> inventoryCells = new Dictionary<string, GameObject>();
    private int used_fields = 5;
    private GameObject panel;
    private void Awake()
    {
        PlayerInventory.OnUpdate += HandleUpdateInventory;
    }

    private void Start()
    {
        panel = Instantiate(panelPrefab);
        for (int i = 0; i < used_fields; i++)
        {
            inventoryCells.Add("",Instantiate(cellPrefab));
        }
        panel.transform.parent = gameObject.transform;
    }

    private void OnDestroy()
    {
        PlayerInventory.OnUpdate -= HandleUpdateInventory;
    }

    private void HandleUpdateInventory(IReadOnlyCollection<Item> inventoryItems)
    {
        used_fields = inventoryItems.Count;
        GameObject[] values = inventoryCells.Values.ToArray();
        inventoryCells.Clear();
        int i = 0;
        foreach (Item item in inventoryItems)
        {
            values[i].GetComponent<Button>().image = item.image;
            inventoryCells.Add(item.name,values[i]);
            i++;
        }
    }
}
