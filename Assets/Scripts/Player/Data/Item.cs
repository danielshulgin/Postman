using UnityEngine.UI;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
    public new string name;
    public string description;
    public Image image;
    public bool isDropable;
    public int amount;
}
