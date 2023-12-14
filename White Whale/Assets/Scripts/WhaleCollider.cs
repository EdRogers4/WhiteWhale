using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleCollider : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide: " + collision);

        if (collision.transform.GetComponent<FraggedChild>() != null)
        {
            collision.transform.GetComponent<FraggedChild>().Damage(15f);
        }
    }
}
