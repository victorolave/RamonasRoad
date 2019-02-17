using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesUI : MonoBehaviour {

    public Pausa pausa;
    

    public void Empezar()
    {
        SceneManager.LoadScene("Nivel");
        Time.timeScale = 1;
    }
    public void Reiniciar()
    { 
        SceneManager.LoadScene("Nivel");
        Time.timeScale = 1;
    }

    public void Inicio()
    {
        SceneManager.LoadScene("Portada");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
