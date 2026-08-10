using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotating : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Rotate(0, speed, 0, Space.World);
    }
}
