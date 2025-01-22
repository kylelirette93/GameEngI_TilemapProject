using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestUI : MonoBehaviour
{
    public TextMeshProUGUI questListText;
    private QuestManager questManager;

    private void Start()
    {
        questManager = FindObjectOfType<QuestManager>();
        UpdateQuestList();
    }

    public void UpdateQuestList()
    {
        questListText.text = "Active Quests:\n";
        foreach (Quest quest in questManager.GetActiveQuests())
        {
            questListText.text += "- " + quest.title + ": " + quest.description + "\n" + "Collected: " + quest.collected;
        }
    }

    public IEnumerator DisplayCompletion()
    {
        questListText.text = "Quest completed, you earned 5 gold!";
        yield return new WaitForSeconds(3f);
        UpdateQuestList();
    }
   
}
