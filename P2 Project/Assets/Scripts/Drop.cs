using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{
    //Based on https://medium.com/@dnwesdman/draggable-ui-in-unity-21fdcbc77bd1
    public string slotName;

    public void OnDrop(PointerEventData eventData)
    {
        Drag draggable = eventData.pointerDrag.GetComponent<Drag>();
        if (draggable != null)
        {
            draggable.startPosition = transform.position;
        }
    }
}
