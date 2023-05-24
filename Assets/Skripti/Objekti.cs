using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina, atraPalidziba, autobuss;
	[HideInInspector]
	public Vector2 atkrMKoord, atrPKoord, busKoord;
	public Canvas kanva;
	public AudioSource skanasAvots;
	public AudioClip[] skanas;
	[HideInInspector]
	public bool irIstajaVieta = false;
	public GameObject pedejaisVilktais = null;
	void Start () {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
		atrPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
		busKoord = autobuss.GetComponent<RectTransform>().localPosition;
	}
}
