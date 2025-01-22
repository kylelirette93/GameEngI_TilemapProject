using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public string title;
    public string description;
    public int collected = 0;
    public int condition;
    public int reward;
    public bool isCompleted;

    public Quest(string title, string description, int condition, int reward)
    {
        this.title = title;
        this.description = description;
        this.condition = condition;
        this.reward = reward;
        this.isCompleted = false;
    }

    public void CompleteQuest()
    {
        if (collected == condition)
        {
            isCompleted = true;
            Debug.Log("Quest completed: " + title);
        }
    }
}
