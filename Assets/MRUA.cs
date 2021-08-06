using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUA : MonoBehaviour
{
    [Range(-8, 8)] public float initPosition;
    public float initVelocity;
    public float aceleration;
    public float maxMovementSeconds;
    public Direction movementDirection;
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
            transform.position = Vector2.right * (initPosition + initVelocity * totalMovingSeconds + 0.5f * aceleration * totalMovingSeconds * totalMovingSeconds);

            //transform.position = 
            //      Vector2.right * initPosition 
            //    + Vector2.right * velocity * totalMovingSeconds 
            //    + Vector2.right * 0.5f * aceleration * totalMovingSeconds * totalMovingSeconds;
            

        }
    }

    public enum Direction
    {
        Right, Up
    }
}
