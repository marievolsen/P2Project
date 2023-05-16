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
        if (PlayerPrefs.HasKey($"Task{number}"))
        {
            SetTitle(PlayerPrefs.GetString($"Task{number}"));
        }
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
        PlayerPrefs.SetString($"Task{number}", title);
    }

    public void SetTaskIndex()
    {
        TaskEditor.taskIndex = number;
    }
}