using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{ 
    [SerializeField] List<Transform> pivotes = new List<Transform>();
    List<GameObject> obstaculosinstanciados = new List<GameObject>();  
    // Start is called before the first frame update
    void Start()
    {
        Generarobstaculos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Generarobstaculos()
    {

        Borrarobstaculos();    
        for (int i = 0; i < pivotes.Count; i++)
        {
            int randomnum = Random.Range(1,5);

            GameObject obstaculo = (GameObject)Instantiate(Resources.Load("obstaculo" + randomnum), pivotes[i]);
            obstaculo.transform.localPosition = Vector3.zero;
            obstaculosinstanciados.Add(obstaculo);
        }
    }

    public void Borrarobstaculos()
    {
        for(int i = 0;i < obstaculosinstanciados.Count; i++)
        {
            Destroy(obstaculosinstanciados[i]);
        }

        obstaculosinstanciados.Clear();
    }
}
