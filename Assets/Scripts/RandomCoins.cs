using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCoins : MonoBehaviour
{
    Vector3 RandomLocation;
    void Start()
    {
        // RandomLocation.x = player.position.x;
        // RandomLocation.y = player.position.y;
        // RandomLocation.z = player.position.z;
        transform.SetPositionAndRotation(new Vector3(Random.Range(-6.20f, 6.20f), 7.1f, Random.Range(10f, 400f)), new Quaternion());
        

    }
}
