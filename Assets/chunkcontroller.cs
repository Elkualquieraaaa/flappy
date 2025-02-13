using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunkcontroller : MonoBehaviour
{
    [SerializeField] List<Transform> transformslist = new List<Transform>();
    [SerializeField] Transform ultimochunk;
    public float velocity = 1;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < transformslist.Count; i++)
        {
            transformslist[i].Translate(Vector3.left*velocity*Time.deltaTime,Space.World);

            if (transformslist[i].position.x <= -6)
            {
                transformslist[i].position = ultimochunk.position + (Vector3.right*6);
                ultimochunk = transformslist[i];
            } 
        }

    }
}
