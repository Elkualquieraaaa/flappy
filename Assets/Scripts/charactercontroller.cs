using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    Rigidbody2D rb;
    Transform transforma;
    [SerializeField] float forcej = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transforma = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y > 0)
        {
            transforma.rotation = Quaternion.Euler(0, 0, 20);
        }
        if(rb.velocity.y < 0)
        {
            transforma.rotation = Quaternion.Euler(0, 0, -20);
        }
    }

    public void Saltar()
    {
        rb.velocity = new Vector2(0,forcej); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Respawn"))
        {
            Controladorjuego.instancia.finalizarjuego();
        }
    }

}
