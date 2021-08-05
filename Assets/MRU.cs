using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRU : MonoBehaviour
{
    [Range(-8, 8)] public float initPosition;
    public float velocity;
    public float maxMovementSeconds;
    private float totalMovingSeconds;

    void Start()
    {
        transform.position = new Vector2(initPosition, 0);
    }

    void Update()
    {
        totalMovingSeconds += Time.deltaTime;

        if (totalMovingSeconds <= maxMovementSeconds)
        {
            transform.position = new Vector2(initPosition, 0) + Vector2.right * velocity * totalMovingSeconds;

        }
    }
}
