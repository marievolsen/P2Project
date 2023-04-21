using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstRedigering : MonoBehaviour
{

    public string tekst;
    public GameObject inputField;
    //public GameObject textDisplay;
    public GameObject[] taskSlotObjects;
  
    // Start is called before the first frame update
    void Start()
    {
        tekst = PlayerPrefs.GetString("textField");
        //textDisplay.GetComponent<Text>().text = tekst;
    }

    public void SaveText()
    {
        tekst = inputField.GetComponent<Text>().text;
        //textDisplay.GetComponent<Text>().text = tekst;

        PlayerPrefs.SetString("textField", tekst);
    }

    public void SendTextToTaskSlot(int taskSlotNumber)
    {
        tekst = inputField.GetComponent<Text>().text;
        GameObject taskSlotObject = taskSlotObjects[taskSlotNumber];
        TaskSlot ts = taskSlotObject.GetComponent<TaskSlot>();
        ts.ChangeTitle(tekst);
    }
}
