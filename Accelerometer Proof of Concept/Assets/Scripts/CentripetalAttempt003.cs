using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentripetalAttempt003 : MonoBehaviour
{
    [SerializeField]
    private float _a;

    [SerializeField]
    private float _V;

    [SerializeField]
    private float _D;

    private Vector3 Pos1;

    // Start is called before the first frame update
    void Start()
    {
        Pos1 = transform.position;
       
    }



    // Update is called once per frame
    void Update()
    {
        var Pos2 = transform.position;

        _D = (Pos2 - Pos1).magnitude;
        _V = (_D) / Time.deltaTime;
        //new float _theta = ;


        //_a = (2 * _V * _V * Mathf.Sin(_theta / 2)) / _D;

        Debug.Log(_D);
        Debug.Log(_V);

        Pos1 = transform.position;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(0.01f); 
        
    }
}
