using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
	public void uzSakumu(){
		SceneManager.LoadScene (0, LoadSceneMode.Single);    //Parslédza ainu uz sákuma ekránu
	}
	public void uzSpeli(){
		SceneManager.LoadScene (1, LoadSceneMode.Single);	//Parslédza ainu uz paśu spéli
	}
	public void Apturet(){
		Application.Quit();									//Aiztaisa aplikáciju
	}
}
