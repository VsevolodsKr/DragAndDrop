using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler
{
	private float vietasZRotacija, velkObjektaZRotacija, rotacijasStarpiba, xIzmStarpiba, yIzmStarpiba;
	private Vector2 vietasIzm, velkObjektaIzm;
	public Objekti objektuSkripts;
	public void OnDrop(PointerEventData eventData)
	{
		if (eventData.pointerDrag != null)
		{
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRotacija = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
				velkObjektaZRotacija = GetComponent<RectTransform>().transform.eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs(vietasZRotacija - velkObjektaZRotacija);
				vietasIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
				velkObjektaIzm = GetComponent<RectTransform>().localScale;
				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjektaIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjektaIzm.y);
				Debug.Log(rotacijasStarpiba + "\n" + xIzmStarpiba + "\n" + yIzmStarpiba);
				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)) && (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{
					Debug.Log("Nomests pareizajā vietā!");
					objektuSkripts.irIstajaVieta = true;
					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
					eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
					eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;
					switch (eventData.pointerDrag.tag)
					{
						case "atkritumi":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[1]);
							break;
						case "palidziba":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[2]);
							break;
						case "auto":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[3]);
							break;
						default:
							Debug.Log("Tags nav definēts!");
							break;
					}

				}
			}
			else
			{
				objektuSkripts.irIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[0]);
				switch (eventData.pointerDrag.tag)
				{
					case "atkritumi":
						objektuSkripts.atkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrMKoord;
						break;
					case "palidziba":
						objektuSkripts.atraPalidziba.GetComponent<RectTransform>().localPosition = objektuSkripts.atrPKoord;
						break;
					case "auto":
						objektuSkripts.autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.busKoord;
						break;
					default:
						Debug.Log("Tags nav definēts!");
						break;
				}
			}
		}
	}
}
