using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorpuntaje : MonoBehaviour
{
    public static controladorpuntaje Instancia;

    public delegate void Delegadopuntaje(int puntaje);

    public Delegadopuntaje actualizarpuntaje;
    public Delegadopuntaje actualizarmejorpuntaje;

    [SerializeField] int puntos = 0;
    [SerializeField] int mejorpuntuacion = 0;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }

        Controladorjuego.instancia.Juegofinalizado += Guardarmejorpuntaje;
    }

    void Start()
    {
        Cargarmejorpuntaje();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sumarpunto()
    {
        puntos++;
        actualizarpuntaje?.Invoke(puntos);
    }

    public void Cargarmejorpuntaje()
    {
        if (PlayerPrefs.HasKey("Mejorpuntaje"))
        {
            mejorpuntuacion = PlayerPrefs.GetInt("Mejorpuntaje");
            actualizarmejorpuntaje?.Invoke(mejorpuntuacion);
        }
    }

    public void Guardarmejorpuntaje()
    {
        if (puntos > mejorpuntuacion)
        {
            PlayerPrefs.SetInt("Mejorpuntaje", puntos);
        }
    }

    public int Obtenerpuntaje()
    {
        return puntos;
    }
}
