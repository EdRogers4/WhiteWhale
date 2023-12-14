using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "No Longer Hunkey Dorey")
        {
            //Physics.gravity = new Vector3(0, 0f, 0);
            other.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            other.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "No Longer Hunkey Dorey")
        {
            //Physics.gravity = new Vector3(0, -1.0f, 0);
            other.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
