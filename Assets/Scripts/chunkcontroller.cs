using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkcontroller : MonoBehaviour
{
    [SerializeField] List<Chunk> chunks = new List<Chunk>();
    [SerializeField] Transform ultimochunk;
    public float velocity = 1;
    public float time = 0;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 10)
        {
            velocity += 0.5f;
            time = 0;
        }
        for (int i = 0; i < chunks.Count; i++)
        {
            chunks[i].transform.Translate(Vector3.left*velocity*Time.deltaTime,Space.World);

            if (chunks[i].transform.position.x <= -5.706f)
            {
                chunks[i].transform.position = ultimochunk.position + (Vector3.right*5.706f);
                ultimochunk = chunks[i].transform;

                chunks[i].Generarobstaculos();
            } 
        }

    }
}
