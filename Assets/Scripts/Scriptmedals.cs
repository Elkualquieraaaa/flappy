using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptmedals : MonoBehaviour
{
    [SerializeField] GameObject medallaplata;
    [SerializeField] GameObject medallaoro;
    int puntos;
    // Start is called before the first frame update
    void Start()
    {
        Controladorjuego.instancia.Juegofinalizado += ActivateMedals;
        puntos = controladorpuntaje.Instancia.Obtenerpuntaje();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ActivateMedals()
    {
        if (puntos > 0 && puntos < 5)
        {
            medallaplata.SetActive(true);
            medallaoro.SetActive(false);
        }
        if (puntos >= 5)
        {
            medallaplata.SetActive(false);
            medallaoro.SetActive(true);
        }
    }
}
