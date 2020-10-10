using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJournal : MonoBehaviour
{
    public static event Action<Quest> OnQuestComplete;
    
    public static event Action<IReadOnlyCollection<Log>> OnUpdatePlayerLogs;
    
    public static event Action<IReadOnlyCollection<QuestInJournal>> OnUpdatePlayerQuests;
    
    [SerializeField] private int maxLogsNumber;
    
    [SerializeField] private int maxQuestsNumber;
    
    [SerializeField] private List<QuestInJournal> quests;
    
    [SerializeField] private List<Log> logs;
    
    public int MaxLogsNumber => maxLogsNumber;
    
    public int MaxQuestsNumber => maxQuestsNumber;
    
    public IReadOnlyCollection<Log> Logs => logs;
    
    public IReadOnlyCollection<QuestInJournal> Quests => quests;

    public static PlayerJournal Instance { get; private set; }

    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;    
        }
        else
        {
            Debug.LogError("Multiple PlayerJournals");
        }
    }


    private void Start()
    {
        OnUpdatePlayerLogs?.Invoke(logs);
        OnUpdatePlayerQuests?.Invoke(quests);
    }

    /// <returns>return false if full</returns>
    public bool AddQuest()
    {
        return true;
    }
    
    /// <returns>return false if full</returns>
    public bool AddLog()
    {
        return true;
    }
    
    public bool ContainsQuest(Quest quest)
    {
        return true;
    }
    
    /// <returns>return true if quest complete</returns>
    public bool IsQuestComplete(Quest quest)
    {
        return true;
    }
    
    /// <returns>return true if success</returns>
    public bool CompleteQuest(Quest quest)
    {
        OnQuestComplete?.Invoke(quest);
        return true;
    }
}

[System.Serializable]
public class QuestInJournal
{
    public bool complete;

    public Quest quest;
}
