using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearTest : MonoBehaviour
{
    [SerializeField]
    private float V = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if(Input.GetKeyDown(KeyCode.W))
        {
            
                V += 0.5f;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            
                V -= 0.5f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (V > 0)
            {
                V -= 0.5f;
            }
            else if (V < 0)
            {
                V += 0.5f;
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = Vector3.zero;
            V = 0;
        }
        /*else
        {
            if(V > 0)
            {
                V--;
            }
            if(V < 0)
            {
                V++;
            }
            if(V == 0)
            {
                V = 0;
            }
        }*/


        transform.Rotate(0, Input.GetAxis("Horizontal") * 200 * Time.fixedDeltaTime, 0);
        transform.Translate(-V * Time.fixedDeltaTime, 0, 0);


    
    
    }

}
