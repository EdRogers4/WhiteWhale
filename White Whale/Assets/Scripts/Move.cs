using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform target;

    void Start()
    {

    }

    void Update()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        //transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide: " + collision);
        
        if (collision.transform.GetComponent<FraggedChild>() != null)
        {
            collision.transform.GetComponent<FraggedChild>().Damage(15f);
        }
    }
}
