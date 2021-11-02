using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
    public Vector3 ranPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.R))
        { 
            randomPosition(ranPosition );
            ranPosition = new Vector3(Random.Range(0, 7), Random.Range(0, 7), Random.Range(0, 7));
        }
    }
    public void randomPosition(Vector3 direccion)
    {
        transform.position = direccion;

    }
}
    

