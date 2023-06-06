using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laiks : MonoBehaviour {
	[HideInInspector] public float laiks;
	public Objekti objektuSkripts;
	void Start () {
		laiks = 0f;
	}

	void Update () {
        laiks += Time.deltaTime;
		}
}
