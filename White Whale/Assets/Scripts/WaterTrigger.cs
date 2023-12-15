using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    [SerializeField] private GameObject hurricaneWeatherVFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "No Longer Hunkey Dorey")
        {
            //Physics.gravity = new Vector3(0, 0f, 0);
            other.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            other.GetComponent<Rigidbody>().useGravity = false;
            hurricaneWeatherVFX.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "No Longer Hunkey Dorey")
        {
            //Physics.gravity = new Vector3(0, -1.0f, 0);
            other.GetComponent<Rigidbody>().useGravity = true;
            hurricaneWeatherVFX.SetActive(true);
        }
    }
}
