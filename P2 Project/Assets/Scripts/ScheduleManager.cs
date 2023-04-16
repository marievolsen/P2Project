using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ScheduleManager : MonoBehaviour
{
    public GameObject taskPrefab;
    [SerializeField] private string[] tasks;

    // Start is called before the first frame update
    void Start()
    {
        foreach (string s in tasks)
        {
            CreateTask(s);
        }
    }

    //Based on https://answers.unity.com/questions/260100/instantiate-as-a-child-of-the-parent.html
    public void CreateTask(string title)
    {
        GameObject taskObject = taskPrefab;
        Task t = taskObject.GetComponent<Task>();
        t.setTitle(title);
        Instantiate(taskObject,Vector3.zero,Quaternion.identity,gameObject.transform);
    }
}
