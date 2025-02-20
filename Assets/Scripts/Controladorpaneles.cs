using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controladorpaneles : MonoBehaviour
{
    [SerializeField] GameObject panelpausa;
    [SerializeField] GameObject panelfinal;
    [SerializeField] GameObject paneljuego;
    [SerializeField] GameObject panelinicio;


    private void Start()
    {
        Controladorjuego.instancia.JuegoIniciado += Mostrarjuego;
        Controladorjuego.instancia.juegopausado += Mostrarpausa;
        Controladorjuego.instancia.Juegofinalizado += Mostrarfinal;
        Controladorjuego.instancia.juegoreaunudado += Mostrarjuego;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mostrarpausa()
    {
        panelpausa.SetActive(true);
        panelfinal.SetActive(false);
        paneljuego.SetActive(false);
        panelinicio.SetActive(false);
    }
    
    public void Mostrarfinal()
    {
        panelfinal.SetActive(true);
        panelinicio.SetActive(false);
        paneljuego.SetActive(false);
        panelpausa.SetActive(false);
    }

    public void Mostrarinicio()
    {
        panelinicio.SetActive(true );
        paneljuego.SetActive(false);
        panelinicio.SetActive(false);
        panelpausa.SetActive(false);
    }

    public void Mostrarjuego()
    {
        paneljuego.SetActive(true);
        panelfinal.SetActive(false);
        panelinicio.SetActive(false);
        panelpausa.SetActive(false );
    }

}
