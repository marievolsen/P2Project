using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


//Based on: https://www.youtube.com/watch?v=Z6pEAngpR9I
public class DateAndTime : MonoBehaviour
{

    public TextMeshPro DateText;
    public TextMeshPro TimeText;

    private void Start()
    {
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy");
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");

        print(date);
        print(time);

        DateText.text = date;
        TimeText.text = time;

    }
}
