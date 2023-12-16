using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleCollider : MonoBehaviour
{
    [SerializeField] private EventManager scriptEventManager;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<FraggedChild>() != null)
        {
            collision.transform.GetComponent<FraggedChild>().Damage(15f);
        }
        else if (collision.transform.tag == "No Longer Hunkey Dorey")
        {
            scriptEventManager.BloodCloud();
        }
    }
}
