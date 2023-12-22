using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBoom : MonoBehaviour
{
    [SerializeField] private TheSoundClipStation scriptTheSoundClipStation;
    [SerializeField] private TraumaInducer scriptTraumaInducer;
    [SerializeField] private bool isCameraShake;
    private int floorDamage;

    public void CountFloorDamage()
    {
        floorDamage += 1;
    }

    public IEnumerator CameraShake()
    {
        if (!isCameraShake)
        {
            isCameraShake = true;
            yield return new WaitForSeconds(0.1f);

            if (floorDamage <= 25)
            {
                scriptTraumaInducer.CameraShake(0.25f);
                scriptTheSoundClipStation.PlayTheSoundOfTheFloorGoingBoom(0);
            }
            else if (floorDamage > 25 && floorDamage <= 50)
            {
                scriptTraumaInducer.CameraShake(0.5f);
                scriptTheSoundClipStation.PlayTheSoundOfTheFloorGoingBoom(1);
            }
            else if (floorDamage > 50 && floorDamage <= 100)
            {
                scriptTraumaInducer.CameraShake(0.75f);
                scriptTheSoundClipStation.PlayTheSoundOfTheFloorGoingBoom(2);
            }
            else if (floorDamage > 100 && floorDamage <= 150)
            {
                scriptTraumaInducer.CameraShake(1.0f);
                scriptTheSoundClipStation.PlayTheSoundOfTheFloorGoingBoom(3);
            }
            else if (floorDamage > 150 && floorDamage <= 200)
            {
                scriptTraumaInducer.CameraShake(1.25f);
                scriptTheSoundClipStation.PlayTheSoundOfTheFloorGoingBoom(4);
            }
            else if (floorDamage > 200 && floorDamage <= 250)
            {
                scriptTraumaInducer.CameraShake(1.5f);
                scriptTheSoundClipStation.PlayTheSoundOfTheFloorGoingBoom(5);
            }
            else if (floorDamage > 250 && floorDamage <= 300)
            {
                scriptTraumaInducer.CameraShake(1.75f);
                scriptTheSoundClipStation.PlayTheSoundOfTheFloorGoingBoom(6);
            }
            else if (floorDamage > 300)
            {
                scriptTraumaInducer.CameraShake(2.0f);
                scriptTheSoundClipStation.PlayTheSoundOfTheFloorGoingBoom(7);
            }

            floorDamage = 0;
            yield return new WaitForSeconds(1.0f);
            isCameraShake = false;
        }
    }
}
