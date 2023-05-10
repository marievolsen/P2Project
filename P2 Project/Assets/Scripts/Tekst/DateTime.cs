using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Globalization;

public class DateTime : MonoBehaviour
{
    //Based on: https://www.youtube.com/watch?v=Z6pEAngpR9I&t=104s

    public TextMeshProUGUI dateText;
    public TextMeshProUGUI currentdayText;
    public TextMeshProUGUI currentmonthText;
    public TextMeshProUGUI currentyearText;
    public TextMeshProUGUI timeText;

    void FixedUpdate()
    {
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy");
        string currentday = System.DateTime.UtcNow.ToLocalTime().ToString("dddd, dd.");
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
