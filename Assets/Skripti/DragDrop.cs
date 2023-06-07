using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
    public Objekti objektuSkripts;
	[HideInInspector] public float laiks, beigaLaiks;
    private CanvasGroup kanvasGrupa;
    private RectTransform velkObjRectTransf;
    public GameObject ekrans, bZvaigzne, sZvaigzne, zZvaigzne;
    public Text laikaAttelosana;
	public Button poga;
    void Start() { 
        kanvasGrupa = GetComponent<CanvasGroup>();
        velkObjRectTransf = GetComponent<RectTransform>();
		laiks = 0f;													//Spéles sákumá annulé laiku
		bZvaigzne.SetActive (false);								//Paslepj visas zvaigznes, lai bútu vieglák rádít vińus péc tam
		sZvaigzne.SetActive (false);
		zZvaigzne.SetActive (false);
		poga.GetComponent<Button> ().interactable = true;			//Poga, kura ir atbildíga par párvietośanu uz sákumu sákumá ir stradośa
    }
	void Update(){
		laiks += Time.deltaTime;								   //Katru kadru laiks palielinás par to deltu
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
				beigaLaiks = laiks;																		//Kad visas maśínas ir savás vietás, mainígais saglabá laika vértíbu
				if (beigaLaiks < 100) {
					bZvaigzne.SetActive (true);															//Balstoties uz mainígas vértíbu parádas zvaigznes
					sZvaigzne.SetActive (true);
					zZvaigzne.SetActive (true);
				} else if (beigaLaiks >= 100 && beigaLaiks < 200) {
					bZvaigzne.SetActive (true);
					sZvaigzne.SetActive (true);
				} else {
					bZvaigzne.SetActive (true);
				}
                ekrans.SetActive(true);																	//Parádas uzvaras ekráns
				laikaAttelosana.GetComponent<Text>().text = beigaLaiks.ToString("F2")+" s";				//Attelo laiku
				poga.GetComponent<Button> ().interactable = false;										//Nońemta iespéja uzklikśḱinát uz pogu, jo uzvaras ekráná táda jau eksisté
            }
        }
        objektuSkripts.irIstajaVieta = false;
    }

}
