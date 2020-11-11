using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    
    private void Start() {
        // Default toggle to Cam 1
        cam1 = GameObject.Find("Main Camera");
        cam2 = GameObject.Find("Main Camera (1)");


        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (cam1.activeSelf && !cam2.activeSelf)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
            }
            else
            {
                cam1.SetActive(true);
                cam2.SetActive(false);  
            }
        }
    }

    private void OnGUI() {
        if (cam1.activeSelf == true)
        {
            GUI.Label(new Rect(10,10,200,20), "Cam 1: Front View");
        }
        if (cam2.activeSelf == true)
        {
            GUI.Label(new Rect(10,10,200,20), "Cam 2: Back View");
        }
    }
}
