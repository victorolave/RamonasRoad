using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {

    int valor = 1;

    private void OnDestroy()
    {
        Puntaje.puntaje += valor;
        Sonido.moneda.Play();
    }
}
