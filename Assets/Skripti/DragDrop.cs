using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
    public Objekti objektuSkripts;
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTransf;
    void Start() { 
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("Uzklikšķināts uz velkama objekta!");
    }

    public void OnPointerDown(PointerEventData eventData){
      
    }

    public void OnDrag(PointerEventData eventData){
      
    }

    public void OnEndDrag(PointerEventData eventData){
      
    }

}
