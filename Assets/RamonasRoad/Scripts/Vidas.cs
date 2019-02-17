using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour {

    int vidas = 3;

    [Header("Canvas")]
    public Canvas canvas;
    public Text mensaje;

    [Header("Posicion Inicial")]
    Vector3 posicionCamara;
    Vector3 posicionRamona;

    [Header("Transforms")]
    public Transform camara;
    Transform ramona;
    public GameObject ramonaObject;

    [Header("Corazones")]
    public GameObject corazon1;
    public GameObject corazon2;
    public GameObject corazon3;
    
	void Start ()
    {
   
        ramona = this.GetComponent<Transform>();
        posicionRamona = ramona.transform.position;
        posicionCamara = camara.transform.position;
	}

	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Acido")
        {
            if(vidas == 3)
            {
                vidas--;
                corazon1.SetActive(false);
                ramona.transform.position = posicionRamona;
                camara.transform.position = posicionCamara;
            }

            else if (vidas == 2)
            {
                vidas--;
                corazon2.SetActive(false);
                ramona.transform.position = posicionRamona;
                camara.transform.position = posicionCamara;

            }

            else if (vidas == 1)
            {
                vidas--;
                corazon3.SetActive(false);
                ramona.transform.position = posicionRamona;
                camara.transform.position = posicionCamara;
               
            }

            if (vidas == 0)
            {
                Debug.Log("PERDISTE");
                Destroy(ramonaObject);
                canvas.enabled = true;
                mensaje.text = "GAME OVER";
            }

        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Final")
        {
            canvas.enabled = true;
            mensaje.text = "YOU WIN";
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        }
    }
}
