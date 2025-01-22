using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Flower : MonoBehaviour
{
    QuestManager questManager;
    QuestUI questUI;
    
    void Start()
    {
        questManager = FindObjectOfType<QuestManager>();
        questUI = FindObjectOfType<QuestUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        questManager.quests[0].collected += 1;
        questUI.UpdateQuestList();
        Destroy(gameObject);
    }


}
