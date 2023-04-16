using UnityEngine;
using TMPro;

public class Task : MonoBehaviour
{
    public void setTitle(string input)
    {
        TextMeshProUGUI taskText = gameObject.GetComponentInChildren<TextMeshProUGUI>();
        taskText.text = input;
    }
}
