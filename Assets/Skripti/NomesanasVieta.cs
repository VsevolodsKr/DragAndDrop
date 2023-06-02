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
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[2]);       //Pieivienotas visas skaņas, ja lietotājs trāpīja ar pareizo mašīnu pareizājā vietā
							break;
						case "auto":
							objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[3]);
							break;
                        case "b2":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[4]);
                            break;
                        case "cements":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[5]);
                            break;
                        case "e46":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[6]);
                            break;
                        case "e61":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[7]);
                            break;
                        case "eskavators":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[8]);
                            break;
                        case "policija":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[9]);
                            break;
                        case "tr1":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[10]);
                            break;
                        case "tr5":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[11]);
                            break;
                        case "uguns":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanas[12]);
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
                    case "b2":
						objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord;
                        break;
                    case "cements":
                        objektuSkripts.cementaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.cemKoord;       //Ja lietotājs netrāpīja pareizājā vietā ar konkrēto mašīnu, tā mašīna atgriežas savā sakotnējā vietā 
                        break;
                    case "e46":
                        objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
                        break;
                    case "e61":
                        objektuSkripts.e61.GetComponent<RectTransform>().localPosition = objektuSkripts.e61Koord;
                        break;
                    case "eskavators":
                        objektuSkripts.eskavators.GetComponent<RectTransform>().localPosition = objektuSkripts.eskKoord;
                        break;
                    case "policija":
                        objektuSkripts.policija.GetComponent<RectTransform>().localPosition = objektuSkripts.polKoord;
                        break;
                    case "tr1":
                        objektuSkripts.traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.tr1Koord;
                        break;
                    case "tr5":
                        objektuSkripts.traktors5.GetComponent<RectTransform>().localPosition = objektuSkripts.tr5Koord;
                        break;
                    case "uguns":
                        objektuSkripts.ugundzeseji.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsKoord;
                        break;
                    default:
						Debug.Log("Tags nav definēts!");
						break;
				}
			}
		}
	}
}
