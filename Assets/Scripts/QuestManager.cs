using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public List<Quest> quests = new List<Quest>();
    QuestUI questUI;
    void Start()
    {
        questUI = FindObjectOfType<QuestUI>();
        quests.Add(new Quest("Flower Picker", "Pick 5 blue flowers to recieve a reward!", 5, 5));
    }

    public void CompleteQuest(string title)
    {
        Quest quest = quests.Find(q => q.title == title);
        if (quest != null && !quest.isCompleted)
        {
            quest.CompleteQuest();
            StartCoroutine(questUI.DisplayCompletion());
        }
    }

    public List<Quest> GetActiveQuests()
    {
        return quests.FindAll(q => !q.isCompleted);
    }
}
