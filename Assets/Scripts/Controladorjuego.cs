using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controladorjuego : MonoBehaviour
{
    public static Controladorjuego instancia;

    public delegate void EventosJuegoDelegado ();
    public EventosJuegoDelegado JuegoIniciado;
    public EventosJuegoDelegado Juegofinalizado;
    public EventosJuegoDelegado juegopausado;
    public EventosJuegoDelegado juegoreaunudado;

    // Start is called before the first frame update
    public void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Time.timeScale = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciarjuego()
    {
        JuegoIniciado?.Invoke();
        Time.timeScale = 1f;
    }

    public void finalizarjuego()
    {
        Juegofinalizado?.Invoke();
        Time.timeScale = 0f;
        SceneManager.LoadScene(0);
    }

    public void pausarjuego()
    {
        juegopausado?.Invoke();
        Time.timeScale = 0f;
    }

    public void reaunudarjuego()
    {
        juegoreaunudado?.Invoke();
        Time.timeScale = 1f;
    }
}
