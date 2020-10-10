using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static event Action<IReadOnlyCollection<Item>> OnUpdate;
    
    [SerializeField] private float maxNumber;
    
    [SerializeField] private List<Item> items;
    
    public float MaxNumber => maxNumber;
    
    public IReadOnlyCollection<Item> Items => items;

    public static PlayerInventory Instance { get; private set; }

    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;    
        }
        else
        {
            Debug.LogError("Multiple Player Inventory");
        }
    }


    private void Start()
    {
        OnUpdate?.Invoke(items);
    }

    /// <returns>return false if full</returns>
    public bool AddItem()
    {
        return true;
    }
    
    public bool ContainsItem()
    {
        return true;
    }
    
    /// <returns>return true if success</returns>
    public bool RemoveItem()
    {
        return true;
    }
}
