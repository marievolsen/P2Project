using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScheduleManager : MonoBehaviour
{
    [SerializeField] private List<Task> tasks = new List<Task> ();

    public void addTaskToSchedule(Task task)
    {
        tasks.Add(task);
    }

    public void PrintSchedule()
    {
        Debug.Log("SCHEDULE:");
        foreach (Task t in tasks)
        {
            Debug.Log($"[TASK] {t.GetTitle()}: [NOTE] {t.GetNote()}.");            
        }
        Debug.Log("END OF SCHEDULE");
    }
}
