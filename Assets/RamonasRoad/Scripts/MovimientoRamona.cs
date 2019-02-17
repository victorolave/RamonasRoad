using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoRamona : MonoBehaviour {

    [Header ("Componentes")]
    Rigidbody2D cuerpoPersonaje = null;
    Animator animator = null;
    SpriteRenderer spriteRenderer = null;
    Transform transf = null;

    [Header("Variables")]
    int jumpcount;
    public float velocidad;
    public float potenciaSalto = 3.0f;
    public  bool pisando;

    [Header("Camara")]
    public Rigidbody2D camara;
    public float velocidadCamara;
    public float ataque;

    public GameObject colliderAttack;

    void Start ()
    {
        //Obtencion Componentes.
        cuerpoPersonaje = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        transf = this.GetComponent<Transform>();
        
	}
   
    void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float salto = Input.GetAxis("Jump");
        ataque = Input.GetAxis("Fire1");
        float correr = Input.GetAxis("Fire2");

        camara.velocity = new Vector2(horizontal*velocidadCamara, 0);
        cuerpoPersonaje.velocity = new Vector2(horizontal * velocidad, cuerpoPersonaje.velocity.y);
        animator.SetFloat("Caminar", Mathf.Abs(horizontal));

        Correr(correr);
        Saltar (salto, horizontal, pisando);
        Direccion (horizontal);
        Atacar (ataque);

	}

    void Saltar(float salto, float horizontal, bool pisando)
    {
        if (salto > 0 && pisando == true)
        {
            cuerpoPersonaje.velocity = new Vector2(horizontal * velocidad, 2 * potenciaSalto);
            animator.SetTrigger("Saltar");
        }
        
    }

    void Direccion (float horizontal)
    {
        if (horizontal > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontal < -0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }

    void Atacar (float ataque)
    {
        if (ataque > 0)
        {
            animator.SetTrigger("Ataque");
        }
    }

    void Correr (float correr)
    {
        if (correr > 0)
        {
            velocidad = 7f;
            velocidadCamara = 6.8f;
            animator.SetTrigger("Correr");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (ataque > 0)
        {
            if (collision.gameObject.tag == "Tanque")
            {
                colliderAttack.SetActive(true);
                Rigidbody2D r = collision.gameObject.GetComponent<Rigidbody2D>();
                r.velocity = new Vector2(100, 0);
                Debug.Log("TOCO");
            }            
        }
        else
        {
            colliderAttack.SetActive(false);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Move")
        {
            this.gameObject.transform.parent = collision.gameObject.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Move")
        {
            this.gameObject.transform.parent = null;
        }
    }
}
