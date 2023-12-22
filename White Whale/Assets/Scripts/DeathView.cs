using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathView : MonoBehaviour
{
    public bool isTheHunkeyDoreyADeadDeadDead;
    [SerializeField] private Transform transformHead;
    private float speedMoveVolume = 50f;
    private float distanceVolumeDeathUnderwater;

    private void Start()
    {
        distanceVolumeDeathUnderwater = Vector3.Distance(transform.position, transformHead.position);
    }

    private void Update()
    {
        if (isTheHunkeyDoreyADeadDeadDead && distanceVolumeDeathUnderwater > 0.01f)
        {
            var step = speedMoveVolume * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transformHead.position, step);
            distanceVolumeDeathUnderwater = Vector3.Distance(transform.position, transformHead.position);
        }
    }

}
