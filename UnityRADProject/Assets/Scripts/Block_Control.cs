using UnityEngine;

public class Block_Control : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // s = u * t where s = distance, u = velocity, and t = time 
        transform.position += 0.01f * Vector3.up;
    }
}
