using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class puntajefinal : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textopuntos;
    [SerializeField] TextMeshProUGUI textompuntos;
    [SerializeField] GameObject medalla1;
    [SerializeField] GameObject medalla2;
    [SerializeField] GameObject medalla3;
    [SerializeField] GameObject medalla4;
    // Start is called before the first frame update
    void OnEnable()
    {
        Actualizarpuntaje(controladorpuntaje.Instancia.Obtenerpuntaje(),controladorpuntaje.Instancia.Obtenermejorpuntaje());
    }

    public void Actualizarpuntaje(int nuevospoints, int mejorespuntos)
    {
        textopuntos.text = nuevospoints.ToString();
        textompuntos.text = mejorespuntos.ToString();


        if (nuevospoints >= 1)
        {
            medalla1.SetActive(true);
            medalla2.SetActive(false);
            medalla3.SetActive(false);
            medalla4.SetActive(false);
        }

        if (nuevospoints >= 10)
        {
            medalla1.SetActive(false);
            medalla2.SetActive(true);
            medalla3.SetActive(false);
            medalla4.SetActive(false);
        }

        if (nuevospoints >= 30)
        {
            medalla1.SetActive(false);
            medalla2.SetActive(false);
            medalla3.SetActive(true);
            medalla4.SetActive(false);
        }
        if(nuevospoints >= 70)
        {
            medalla1.SetActive(false);
            medalla2.SetActive(false);
            medalla3.SetActive(false);
            medalla4.SetActive(true);
        }

    }
}
