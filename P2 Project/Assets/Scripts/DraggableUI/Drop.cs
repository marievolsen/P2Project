using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    //Based on https://medium.com/@dnwesdman/draggable-ui-in-unity-21fdcbc77bd1
    public GameObject scheduleManager;
    
    public void OnDrop(PointerEventData eventData)
    {
        Drag draggable = eventData.pointerDrag.GetComponent<Drag>();
        if (draggable != null)
        {
            draggable.startPosition = transform.position;
        }

        Task task = eventData.pointerDrag.GetComponent<Task>();
        ScheduleManager sm = scheduleManager.GetComponent<ScheduleManager>();
        sm.addTaskToSchedule(task);
        Destroy(task.gameObject);
    }
}
