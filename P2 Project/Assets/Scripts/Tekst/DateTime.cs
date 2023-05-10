using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DateTime : MonoBehaviour
{
    //Based on: https://www.youtube.com/watch?v=Z6pEAngpR9I&t=104s

    public TextMeshPro dateText;
    public TextMeshPro currentdayText;
    public TextMeshPro currentmonthText;
    public TextMeshPro currentyearText;
    public TextMeshPro timeText;

    void Start()
    {
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy");
        string currentday = System.DateTime.UtcNow.ToLocalTime().ToString("dd");
        string curentmonth = System.DateTime.UtcNow.ToLocalTime().ToString("MM");
        string currentyear = System.DateTime.UtcNow.ToLocalTime().ToString("yyyy");
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");

        dateText.text = date;
        currentdayText.text = currentday;
        currentmonthText.text = curentmonth;
        currentyearText.text = currentyear;
        timeText.text = time;

    }

}
