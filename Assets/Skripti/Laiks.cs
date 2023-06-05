using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laiks : MonoBehaviour {
	private float laiks;
	[HideInInspector] public bool masinasIrSavasVietas;
	void Start () {
		laiks = 0f;
		masinasIrSavasVietas = false;
	}

	void Update () {
		while (masinasIrSavasVietas == false) {
			laiks += Time.deltaTime;
			Debug.Log (laiks.ToString ("F2"));
		}
		}
}
