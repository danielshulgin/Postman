using UnityEngine;


[CreateAssetMenu(fileName = "Quest", menuName = "ScriptableObjects/Item", order = 0)]
public class Quest : ScriptableObject
{
    [SerializeField] private Item questItem;
    
    public Item QuestItem => questItem;
}
