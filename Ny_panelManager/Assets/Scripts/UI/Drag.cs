using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDropHandler, IDragHandler  
{
    //Based on https://medium.com/@dnwesdman/draggable-ui-in-unity-21fdcbc77bd1
    public Image thisImage;
    public Vector3 startPosition;

    private void Start()
    {
        thisImage = GetComponent<Image>();
        
    }

    public void Update()
    {
        startPosition = transform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        thisImage.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = startPosition;
        thisImage.raycastTarget = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}