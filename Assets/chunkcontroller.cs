using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkcontroller : MonoBehaviour
{
    [SerializeField] List<Chunk> chunks = new List<Chunk>();
    [SerializeField] Transform ultimochunk;
    public float velocity = 1;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < chunks.Count; i++)
        {
            chunks[i].transform.Translate(Vector3.left*velocity*Time.deltaTime,Space.World);

            if (chunks[i].transform.position.x <= -6)
            {
                chunks[i].transform.position = ultimochunk.position + (Vector3.right*6);
                ultimochunk = chunks[i].transform;

                chunks[i].Generarobstaculos();
            } 
        }

    }
}
