using UnityEngine;
using TMPro;

public class Task : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI taskTitle;
    [SerializeField] string taskNote;

    public void SetTitle(string input)
    {
        taskTitle = GetComponentInChildren<TextMeshProUGUI>();
        taskTitle.text = input;
    }

    public string GetTitle()
    {
        return taskTitle.text;
    }
    
    public void SetNote(string input)
    {
        taskNote = input;
    }

    public string GetNote()
    {
        return taskNote;
    }
}
