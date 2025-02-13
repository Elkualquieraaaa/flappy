using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class controladorplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textopuntos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Actualizarpuntaje(int nuevospoints)
    {
        textopuntos.text = nuevospoints.ToString();
    }
}
