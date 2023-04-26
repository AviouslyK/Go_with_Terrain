using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Script to implement click and drag for the Stones

public class Draggable : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IInitializePotentialDragHandler
{   
    
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        eventData.useDragThreshold = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //throw new System.NotImplementedException;
        Debug.Log("OnPointerDown");
    }

    // called every frame
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 weight = new Vector2(0.1f, 0.1f);
        rectTransform.anchoredPosition += weight*eventData.delta/rectTransform.lossyScale; // increase by movement delta (amount mouse moved since previous frame)
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }


}
