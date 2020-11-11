using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    float _speed;
    float _rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _speed = 5f;
        _rotateSpeed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(-10f, 0, 0)  * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(10f, 0, 0) * _speed * Time.deltaTime);
        }   
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -10f, 0) * _rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {   
            transform.Rotate(new Vector3(0, 10f, 0) * _rotateSpeed * Time.deltaTime);
        }
    }
}
