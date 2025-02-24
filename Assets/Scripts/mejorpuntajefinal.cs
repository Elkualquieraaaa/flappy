using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class mejorpuntajefinal : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textopuntos;
    // Start is called before the first frame update
    void OnEnable()
    {
        Actualizarpuntaje(controladorpuntaje.Instancia.Obtenermejorpuntaje());
    }

    public void Actualizarpuntaje(int nuevospoints)
    {
        textopuntos.text = nuevospoints.ToString();
    }
}
