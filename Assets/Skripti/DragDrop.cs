using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
    public Objekti objektuSkripts;
    [HideInInspector] public Laiks beigaLaiks;
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTransf;
    public GameObject ekrans;
    public Text laikaAttelosana;
    void Start() { 
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
    }

    public void OnBeginDrag(PointerEventData eventData){
        Debug.Log("Uzklikšķināts uz velkama objekta!");
        objektuSkripts.pedejaisVilktais = null;
        kanvasGrupa.alpha = 0.6f;
        kanvasGrupa.blocksRaycasts = false;
    }

    public void OnPointerDown(PointerEventData eventData){
      
    }

    public void OnDrag(PointerEventData eventData){
        velkObjRectTransf.anchoredPosition += eventData.delta / objektuSkripts.kanva.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData){
        objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
        kanvasGrupa.alpha = 1.0f;
        if (objektuSkripts.irIstajaVieta == false)
        {
            kanvasGrupa.blocksRaycasts = true;
        }
        else {
            objektuSkripts.skaita++;
            objektuSkripts.pedejaisVilktais = null;
            if(objektuSkripts.skaita == 12){
                ekrans.SetActive(true);
                laikaAttelosana.text = beigaLaiks.laiks.ToString("F2") + " s";
            }
        }
        objektuSkripts.irIstajaVieta = false;
    }

}
