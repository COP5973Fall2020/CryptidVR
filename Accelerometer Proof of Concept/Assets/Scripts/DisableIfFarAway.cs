using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableIfFarAway : MonoBehaviour
{
    private GameObject itemActivatorObj;
    private ItemActivator activationScript;


    // Start is called before the first frame update
    void Start()
    {
        // Get itemActivator object
        itemActivatorObj = GameObject.Find("ItemActivatorObject");
        if (itemActivatorObj == null)
        {
            Debug.Log("*--> itemActivatorObj is NULL!");
        }

        // Get activationScript component
        activationScript = itemActivatorObj.GetComponent<ItemActivator>();
        if (activationScript == null)
        {
            Debug.Log("**--> activationScript is NULL!");
        }
        
        // Add new item to activatorItems
        activationScript.activatorItems.Add(new ActivatorItem { item = this.gameObject, itemPos = transform.position });
        if (activationScript.activatorItems == null)
        {
            Debug.Log("***--> activationScript.activatorItems is NULL!");
        }       
    }
}
