using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour {

    Canvas canvasPausa;
	
	void Start ()
    {
        canvasPausa = GetComponent<Canvas>();
        canvasPausa.enabled = false;
	}

    public void Pausar()
    {
        canvasPausa.enabled = !canvasPausa.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}
}
