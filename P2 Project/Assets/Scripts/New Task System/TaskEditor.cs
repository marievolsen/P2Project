using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TaskEditor : MonoBehaviour
{
    public static int taskIndex;
    [SerializeField] private string taskDefinition;
    [SerializeField] private string placeholderMessage;
    [SerializeField] private string editButtonMessage;
    [SerializeField] private TextMeshProUGUI taskIndexText; 
    [SerializeField] private TextMeshProUGUI taskText;
    [SerializeField] private TextMeshProUGUI placeholderText;
    [SerializeField] private TextMeshProUGUI editButtonText;
    [SerializeField] private TextMeshProUGUI inputText;
    private NewTask nt;

    private void Awake()
    {
        taskIndexText.text = $"{taskDefinition} #{taskIndex}:";
        
        nt = GameObject.Find($"Task{taskIndex}").GetComponent<NewTask>();
        taskText.text = nt.GetTitle();

        placeholderText.text = placeholderMessage;
        editButtonText.text = editButtonMessage;
    }

    public void EditTask()
    {
        nt.SetTitle(inputText.text);
        taskText.text = inputText.text;
    }
}