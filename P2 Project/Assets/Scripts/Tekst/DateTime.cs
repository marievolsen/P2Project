using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Globalization;

public class DateTime : MonoBehaviour
{
    //Based on: https://www.youtube.com/watch?v=Z6pEAngpR9I&t=104s

    public TextMeshProUGUI dateText;
    public TextMeshProUGUI currentdateText;
    public TextMeshProUGUI currentmonthText;
    public TextMeshProUGUI calendarmonthText;
    public TextMeshProUGUI currentyearText;
    public TextMeshProUGUI timeText;

    void FixedUpdate()
    {
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy");
        string currentdate = System.DateTime.UtcNow.ToLocalTime().ToString("dddd, dd. MMMM");
        string curentmonth = System.DateTime.UtcNow.ToLocalTime().ToString("MMMM");
        string calendarmonth = System.DateTime.UtcNow.ToLocalTime().ToString("MMMM");
        string currentyear = System.DateTime.UtcNow.ToLocalTime().ToString("yyyy");
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");

        dateText.text = date;
        currentdateText.text = currentdate;
        currentmonthText.text = curentmonth;
        currentyearText.text = currentyear;
        timeText.text = time;
        calendarmonthText.text = calendarmonth;

    }

}
