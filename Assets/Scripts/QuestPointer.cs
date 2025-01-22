using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class QuestPointer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    QuestManager questManager;
   
    void Start()
    {
        questManager = FindObjectOfType<QuestManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    IEnumerator PointToQuestSpot(Vector3 giverLocation)
    {
        foreach (Quest quest in questManager.GetActiveQuests())
        {
            spriteRenderer.enabled = true;
            transform.position = giverLocation;
        }
        yield return null;
    }
}
