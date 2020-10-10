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
    private GameObject panel;
    private Image defaultImage;
    
    private void Awake()
    {
        PlayerInventory.OnUpdate += HandleUpdateInventory;
    }

    private void Start()
    {
        panel = Instantiate(panelPrefab);
        defaultImage = cellPrefab.GetComponent<Button>().image;
        for (int i = 0; i < 5; i++)
        {
            inventoryCells.Add(i.ToString(),Instantiate(cellPrefab));
        }
        panel.transform.parent = gameObject.transform;
    }

    private void OnDestroy()
    {
        PlayerInventory.OnUpdate -= HandleUpdateInventory;
    }

    private void HandleUpdateInventory(IReadOnlyCollection<Item> inventoryItems)
    {
        int used_fields = inventoryItems.Count;
        GameObject[] values = inventoryCells.Values.ToArray();
        inventoryCells.Clear();
        int i = 0;
        foreach (Item item in inventoryItems)
        {
            values[i].GetComponent<Button>().image = item.image;
            inventoryCells.Add(item.name,values[i]);
            i++;
        }

        for (int j = used_fields; j < 5; j++)
        {
            values[i].GetComponent<Button>().image = defaultImage;
        }
        
    }
}
