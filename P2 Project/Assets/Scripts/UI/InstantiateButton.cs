using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class InstantiateButton : MonoBehaviour
{
    public GameObject Picture;
    public string Dagskema;
    private static Canvas Canvas;
    public static Canvas canvas
    {
        get
        {
            if (Canvas == null)
            {
                Canvas = FindObjectOfType<Canvas>();


                if (Canvas == null)
                {
                    Canvas = new GameObject("SpawnCanvas", typeof(Canvas)).GetComponent<Canvas>();
                }

            }
            return Canvas;
        }
        private set
        {
            Canvas = value;
        }
    }

    public void SpawnPicture()
    {
        Instantiate();
    }

    private void Instantiate()
    {
        GameObject newObj = Instantiate(Picture);
        newObj.transform.SetParent(GameObject.Find("Content").transform);
    }
}


