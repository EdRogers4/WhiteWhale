using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleMovement : MonoBehaviour
{
    [SerializeField] private float speedMove;
    [SerializeField] private float speedRotate;
    [SerializeField] private Transform target;

    void Start()
    {

    }

    void Update()
    {
        var step = speedMove * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        Vector3 targetDirection = target.position - transform.position;
        float singleStep = speedRotate * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
