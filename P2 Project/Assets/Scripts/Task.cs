using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Task : MonoBehaviour
{
    [SerializeField] private string title;
    [SerializeField] private TextMeshProUGUI titleText;

    private void Start()
    {
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
    }
}
