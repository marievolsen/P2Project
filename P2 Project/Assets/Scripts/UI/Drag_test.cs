using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_test : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDropHandler, IDragHandler
{
    [SerializeField] private Canvas canvas1;
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

    private RectTransform rectTransform;
    private Rigidbody2D kevin;
    private CanvasGroup canvasGroup;


    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        kevin = GetComponent<Rigidbody2D>();
        canvasGroup = GetComponent<CanvasGroup>();
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = .6f;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnDrop(PointerEventData eventData)
    {
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

   
}
