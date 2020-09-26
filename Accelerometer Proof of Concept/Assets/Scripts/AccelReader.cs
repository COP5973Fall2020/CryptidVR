using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelReader : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
         

    }

    // Update is called once per frame
    void Update()
    {
        float _a = GameObject.Find("Vehicle").GetComponent<Coroutine_Test>()._a;
        transform.SetPositionAndRotation(transform.position, Quaternion.Euler(-_a, 0, 0));
    }
}
