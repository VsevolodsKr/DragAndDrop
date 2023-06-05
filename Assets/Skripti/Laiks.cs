using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laiks : MonoBehaviour {
	private float laiks;
	[HideInInspector] public bool irSavasVietas;
	void Start () {
		laiks = 0f;
		irSavasVietas = false;
	}

	void Update () {
		while (irSavasVietas == false) {
			laiks += Time.deltaTime;
			Debug.Log (laiks.ToString ("F2"));
		}
		}
}
