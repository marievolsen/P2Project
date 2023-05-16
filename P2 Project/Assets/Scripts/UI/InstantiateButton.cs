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
        Transform parentTransform = GameObject.Find("Content").transform;
        newObj.transform.SetParent(parentTransform);
        newObj.transform.position = new Vector3((float)714.643127, (float)1784.979, 0);
    }
}


