using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaV : MonoBehaviour
{
    private Vector3 xLast;
    private Vector3 vLast;


    [SerializeField]
    private Transform _arrow;

    [SerializeField]
    private float _deltaTime;

    // Start is called before the first frame update
    void Start()
    {
        xLast = transform.position;
       //StartCoroutine(Wait());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 xNow = transform.position;
        Vector3 vNow = (xNow - xLast) / Time.fixedDeltaTime;
        Vector3 a = (vNow - vLast) / Time.fixedDeltaTime;

        Debug.Log((a.magnitude));
        Debug.DrawRay(transform.position, (a + new Vector3(0, -50f, 0)));

        vLast = vNow;
        xLast = transform.position;
        
    }

    /*IEnumerator Wait()
    {
        for (int i = 0; i < 9999; i++)
        {
           Vector3 xNow = transform.position;
            Vector3 vNow = (xNow - xLast) / Time.deltaTime;
            Vector3 a = (vNow - vLast) / Time.deltaTime;

            Debug.Log(vNow.magnitude);

            vLast = vNow;
            xLast = transform.position;
            yield return new WaitForSeconds(_deltaTime);
        }
    }*/
}
