using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstRedigering : MonoBehaviour
{
    public string text;
    public GameObject inputField;
    public GameObject[] taskSlotObjects;
  
    public void SendTextToTaskSlot(int taskSlotNumber)
    {
        text = inputField.GetComponent<Text>().text;
        GameObject taskSlotObject = taskSlotObjects[taskSlotNumber];
        TaskSlot ts = taskSlotObject.GetComponent<TaskSlot>();
        ts.ChangeTitle(text);
    }
}
