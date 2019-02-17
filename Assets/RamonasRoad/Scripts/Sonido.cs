using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    public AudioSource sound;
    public static AudioSource moneda;

    private void Start()
    {
        moneda = sound;
    }

}
