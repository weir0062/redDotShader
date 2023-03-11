using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderMover : MonoBehaviour
{

    Renderer rend; 
    Vector3 Position;
    public float Speed = 6.9f;
    float time = 0.0f;
    private Material poopMattiew;
    void Start()
    {
        poopMattiew = GetComponent<Renderer>().material;
      
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            Position.y += Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Position.x -= Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Position.y -= Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Position.x += Speed * Time.deltaTime;
        }

        if (poopMattiew)
        {
            poopMattiew.SetVector("_Position", Position);
        }
    }
}
