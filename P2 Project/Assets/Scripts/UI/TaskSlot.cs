using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskSlot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI taskSlotTitle;
    [SerializeField] private GameObject taskObject;


    public void Awake()
    {
        taskSlotTitle = GetComponentInChildren<TextMeshProUGUI>();
        taskSlotTitle.text = gameObject.name;
        taskObject = GameObject.Find(this.gameObject.name);
    }

    public void ChangeTitle(string input)
    {
        Task t = taskObject.GetComponent<Task>();
        t.SetTitle(input);
    }
}