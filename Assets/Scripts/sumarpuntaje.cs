using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumarpuntaje : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            controladorpuntaje.Instancia.Sumarpunto();
        }
    }
}
