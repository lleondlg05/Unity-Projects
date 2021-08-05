using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUA : MonoBehaviour
{
    [Range(-8, 8)] public float initPosition;
    public float velocity;
    public float aceleration;
    public float maxRoadCounter;
    private float counter;

    void Start()
    {
        transform.position = new Vector2(initPosition, 0);
    }

    void Update()
    {
        counter += Time.deltaTime;

        if (counter <= maxRoadCounter)
        {
            transform.Translate(Vector2.right * velocity * Time.deltaTime);

        }
    }
}
