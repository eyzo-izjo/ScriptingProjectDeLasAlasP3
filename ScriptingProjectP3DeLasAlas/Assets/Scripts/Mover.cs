using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 5f;
    GameObject gameObject;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.renderer.material.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * (speed * Time.deltaTime);
    }
}
