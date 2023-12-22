using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleCollider : MonoBehaviour
{
    [SerializeField] private DeathView scriptDeathView;
    [SerializeField] private BoneCloud scriptBoneCloud;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<FraggedChild>() != null)
        {
            collision.transform.GetComponent<FraggedChild>().Damage(15f);
        }
        else if (collision.transform.tag == "No Longer Hunkey Dorey")
        {
            scriptBoneCloud.TurnTheHunkeyDoreyNoLongerIntoABoneCloud();
            scriptDeathView.isTheHunkeyDoreyADeadDeadDead = true;
        }
    }
}
