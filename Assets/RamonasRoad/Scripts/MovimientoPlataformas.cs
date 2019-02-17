using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataformas : MonoBehaviour
{
    public float amplitudX = 1.0f;
    public float amplitudY = 1.0f;
    public float speed = 0.5f;

    private float x;
    private float y;
    private float tiempo;
    private Vector3 posicionActual;


    void Start ()
    {
        posicionActual = this.transform.position;
        
	}
	
	void Update ()
    {
        tiempo += Time.deltaTime;

        x = posicionActual.x + (amplitudX * Mathf.Cos(tiempo * speed));
        y = posicionActual.y + (amplitudY * Mathf.Sin(tiempo * speed));

        this.transform.position = new Vector3(x, y, 0);
    }
}
