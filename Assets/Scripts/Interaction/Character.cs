using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{
    [SerializeField] private Quest quest;
    
    [SerializeField] private List<Phrase> dialogBeforeQuest;
    
    [SerializeField] private List<Phrase> dialogAfterQuest;

    public List<Phrase> DialogBeforeQuest => dialogBeforeQuest;

    public List<Phrase> DialogAfterQuest => dialogAfterQuest;

    public Quest Quest => quest;
}
