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

    void Update()
    {
        Vector2 direction = Vector2.right;
        if(Direction.Right == movementDirection)
        {
            direction = Vector2.right;
        }
        else
        {
            direction = Vector2.up;
        }
        
        totalMovingSeconds += Time.deltaTime;

        if (totalMovingSeconds <= maxMovementSeconds)
        {
            Vector3 currentPosition = transform.position;
            if(Direction.Right == movementDirection)
            {
                currentPosition.x = (initPosition + initVelocity * totalMovingSeconds + 0.5f * aceleration * totalMovingSeconds * totalMovingSeconds);
            }
            else
            {
                currentPosition.y = (initPosition + initVelocity * totalMovingSeconds + 0.5f * aceleration * totalMovingSeconds * totalMovingSeconds);
            }
            transform.position = currentPosition;

            //transform.position = 
            //      Vector2.right * initPosition 
            //    + Vector2.right * velocity * totalMovingSeconds 
            //    + Vector2.right * 0.5f * aceleration * totalMovingSeconds * totalMovingSeconds;


        }
        else
            totalMovingSeconds = 0;
    }

    public enum Direction
    {
        Right, Up
    }
}
