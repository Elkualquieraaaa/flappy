using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float forcej = 1;
    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saltar()
    {
        rb.velocity = new Vector2(0,forcej); 
    }
}
