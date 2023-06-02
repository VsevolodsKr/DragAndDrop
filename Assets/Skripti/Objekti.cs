﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina, atraPalidziba, autobuss, b2, cementaMasina, e46, e61, eskavators, policija, traktors1, traktors5, ugundzeseji;
	[HideInInspector]
	public Vector2 atkrMKoord, atrPKoord, busKoord, b2Koord, cemKoord, e46Koord, e61Koord, eskKoord, polKoord, tr1Koord, tr5Koord, ugunsKoord;
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
        b2Koord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        cemKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        e46Koord = autobuss.GetComponent<RectTransform>().localPosition;
        e61Koord = atkritumuMasina.GetComponent<RectTransform>().localPosition;      //Visiem objektiem ir nolasītas visas pozīcijas
        eskKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        polKoord = autobuss.GetComponent<RectTransform>().localPosition;
        tr1Koord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        tr5Koord = atraPalidziba.GetComponent<RectTransform>().localPosition;
        ugunsKoord = autobuss.GetComponent<RectTransform>().localPosition;
    }
}
