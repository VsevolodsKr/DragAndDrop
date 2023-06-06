using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UzvarasEkrans : MonoBehaviour {
    public void Restart() {
        SceneManager.LoadScene("Karte");
    }
}
