using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciarjuego()
    {
        JuegoIniciado?.Invoke();
    }

    public void finalizarjuego()
    {
        Juegofinalizado?.Invoke();
    }

    public void pausarjuego()
    {
        juegopausado?.Invoke();
    }

    public void reaunudarjuego()
    {
        juegoreaunudado?.Invoke();
    }
}
