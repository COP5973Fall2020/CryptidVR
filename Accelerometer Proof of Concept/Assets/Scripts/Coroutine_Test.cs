using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class Coroutine_Test : MonoBehaviour
{
    
    public float _a;

    [SerializeField]
    private float _V;

    [SerializeField]
    private float _D;

    private Vector3 Pos1;

    private Vector3 _origin = new Vector3(0, 0, 0);

    [SerializeField]
    private float _deltaTime;

    // Start is called before the first frame update
    void Start()
    {
        Pos1 = transform.position;
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    /*void Update()
    {
        var Pos2 = transform.position;

        _D = (Pos2 - Pos1).magnitude;
        _V = (_D) / Time.deltaTime;
        float _theta = Vector3.Angle(Pos1, Pos2);


        _a = (2 * _V * _V * Mathf.Sin((_theta * Mathf.PI / 180) / 2)) / _D;

        Pos1 = transform.position;
        //yield return new WaitForSeconds(_deltaTime);
    }*/
    
    /*void Centripetal()
    {
        var Pos2 = transform.position;

        _D = (Pos2 - Pos1).magnitude;
        _V = (_D) / Time.deltaTime;
        float _theta = Vector3.Angle(Pos1, Pos2);


        _a = (2 * _V * _V * Mathf.Sin(_theta / 2)) / _D;

        Debug.Log(_D);
        Debug.Log(_V);

        Pos1 = transform.position;
    }*/

    IEnumerator Wait()
    {
        for(int i = 1; i < 10000; i ++)
        {
            var Pos2 = transform.position;

            _D = (Pos2 - Pos1).magnitude;
            _V = (_D) / _deltaTime;
            //find formula for linear velocity from angular, as this will be more accurate...maybe.
            float _theta = Vector3.Angle(Pos1, Pos2);

            //Maybe add an r variable instead of writing the whole equation here
            _a = (2 * _V *_V * Mathf.Sin(((_theta * Mathf.PI/180) / 2)) / _D);
                        
            Pos1 = transform.position;
            yield return new WaitForSeconds(_deltaTime);
        }
        
        

    }
}
