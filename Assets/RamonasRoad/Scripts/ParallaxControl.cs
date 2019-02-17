using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxControl : MonoBehaviour {

    [Header ("Componentes")]
    private Renderer rend;

    [Header("Variables")]
    public float speed = 2.0f;
    private float tiempo;
    

	void Start ()
    {
        rend = this.GetComponent<Renderer>();      
	}
	
	void Update ()
    {
        tiempo += Time.deltaTime;
        rend.material.mainTextureOffset = new Vector2(tiempo * speed, 0);
    }
}
