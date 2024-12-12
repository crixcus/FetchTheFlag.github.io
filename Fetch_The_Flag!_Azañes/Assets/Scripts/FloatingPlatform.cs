using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlatform : MonoBehaviour
{
    public float amplitude = 10f; 
    public float frequency = 1.3f; 

    private Vector3 startPos; 
    private float elapsedTime;     

    void Start()
    {
        
        startPos = transform.position;
    }

    void Update()
    {
        
        elapsedTime += Time.deltaTime;
        float newY = startPos.y + Mathf.Sin(elapsedTime * frequency) * amplitude;

        
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
