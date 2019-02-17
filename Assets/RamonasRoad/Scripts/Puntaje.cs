using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public static int puntaje = 0;
    public Text txtPuntaje;

    private void Start()
    {
        puntaje = 0;
    }
    void Update ()
    {       
        txtPuntaje.text = "= " +puntaje.ToString();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }
}
