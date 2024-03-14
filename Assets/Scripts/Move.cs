using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1.3f;
  
    void Start()
    {
        
    }


    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime;
    }
}
