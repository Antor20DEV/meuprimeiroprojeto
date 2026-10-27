using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 forceDirection;

    private void SpawnObject()
    {
        var obj = Instantiate(prefab, transform);

        obj.GetComponent<Rigidbody>().AddForce(forceDirection);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();

        }
        
    }
     
}
