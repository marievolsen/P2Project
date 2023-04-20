using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskSlot : MonoBehaviour
{
    //Based on https://docs.unity3d.com/ScriptReference/GameObject.Find.html
    [SerializeField] private TextMeshProUGUI taskSlotTitle;
    [SerializeField] private GameObject taskObject;
    [SerializeField] private string taskObjectName;

    public void Awake()
    {
        taskSlotTitle = GetComponentInChildren<TextMeshProUGUI>();
        taskSlotTitle.text = gameObject.name;
        taskObject = GameObject.Find(taskObjectName);
    }

    public void ChangeTitle(string input)
    {
        Task t = taskObject.GetComponent<Task>();
        t.SetTitle(input);
    }
}
