using TMPro;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField] private string title;
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private int taskNumber;

    private void Start()
    {
        if (PlayerPrefs.GetString($"TaskText{taskNumber}") != "")
        {
            title = PlayerPrefs.GetString($"TaskText{taskNumber}");
        }
        titleText = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Update()
    {
        titleText.text = title;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string input)
    {
        title = input;
        PlayerPrefs.SetString($"TaskText{taskNumber}", title);
    }
}