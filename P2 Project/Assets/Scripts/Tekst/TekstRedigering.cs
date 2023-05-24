using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TekstRedigering : MonoBehaviour
{

    public string tekst;
    public GameObject inputField;
    public GameObject[] taskSlotObjects;

    public void SendTextToTaskSlot(int taskSlotNumber)
    {
        tekst = inputField.GetComponent<Text>().text;
        GameObject taskSlotObject = taskSlotObjects[taskSlotNumber];
        TaskSlot ts = taskSlotObject.GetComponent<TaskSlot>();
        ts.ChangeTitle(tekst);
    }
}