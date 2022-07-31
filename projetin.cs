using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Debug;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            transform.Rotate(0, -5.0f, 0, Space.Self);
        }
        if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            transform.Rotate(0, 5.0f, 0, Space.Self);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
 
    }

    void OnCollisionExit(Collision collision)
    {
 
    }
}
