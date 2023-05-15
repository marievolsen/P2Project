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
    public TextMeshProUGUI calendaryearText;
    public TextMeshProUGUI timeText;

    void FixedUpdate()
    {
        string date = System.DateTime.UtcNow.ToLocalTime().ToString("dd-MM-yyyy");
        string currentdate = System.DateTime.UtcNow.ToLocalTime().ToString("dddd, dd. MMMM");
        string curentmonth = System.DateTime.UtcNow.ToLocalTime().ToString("MMMM");
        string time = System.DateTime.UtcNow.ToLocalTime().ToString("HH:mm");

        string calendarmonth = System.DateTime.UtcNow.ToLocalTime().ToString("MMMM");
        string calendaryear = System.DateTime.UtcNow.ToLocalTime().ToString("yyyy");

        dateText.text = date;
        currentdateText.text = currentdate;
        currentmonthText.text = curentmonth;
        calendaryearText.text = calendaryear;
        timeText.text = time;
        calendarmonthText.text = calendarmonth;

    }

}
