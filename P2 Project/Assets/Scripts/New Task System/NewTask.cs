using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewTask : MonoBehaviour
{
    [SerializeField] private int number; 
    [SerializeField] private string title;
    [SerializeField] private TextMeshProUGUI titleText;

    private void Start()
    {
        titleText = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (title == "")
        {
            title = $"#{number}";
        }
        titleText.text = title;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string input)
    {
        title = input;
    }

    public void SetTaskIndex()
    {
        TaskEditor.taskIndex = number;
    }
}