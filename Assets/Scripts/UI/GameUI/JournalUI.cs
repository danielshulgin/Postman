using System.Collections.Generic;
using UnityEngine;

public class LogUI : MonoBehaviour
{
    private void Awake()
    {
        PlayerJournal.OnUpdatePlayerLogs += HandleUpdatePlayerLogs;
        PlayerJournal.OnUpdatePlayerQuests += HandleUpdatePlayerQuests;
    }

    private void OnDestroy()
    {
        PlayerJournal.OnUpdatePlayerLogs -= HandleUpdatePlayerLogs;
        PlayerJournal.OnUpdatePlayerQuests -= HandleUpdatePlayerQuests;
    }

    private void HandleUpdatePlayerLogs(IReadOnlyCollection<Log> logs)
    {
        
    }
    
    private void HandleUpdatePlayerQuests(IReadOnlyCollection<QuestInJournal> quests)
    {
        
    }
}
