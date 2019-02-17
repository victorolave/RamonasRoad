using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour {

    public MovimientoRamona movR;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Suelo" || collision.gameObject.tag == "Move")
        {
            movR.pisando = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo" || collision.gameObject.tag == "Move")
        {
            movR.pisando = false;
        }           
    }

   

}
