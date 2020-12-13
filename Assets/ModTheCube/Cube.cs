using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float rotationSpeed = 12.5f;
    
    void Start()
    {
        transform.position = new Vector3(2, 5, 0.1f);
        transform.localScale = Vector3.one * 1.5f;
        
        Material material = Renderer.material;

        //material.color = new Color(0.5f, 1.0f, 0.35f, 0.5f);

        material.color = new Color(Random.value, Random.value, Random.value);
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0.0f, 0.0f); // around x
        //transform.Rotate(0.0f, 15.0f * Time.deltaTime, 0.0f); // around y
        //transform.Rotate(0.0f, 0.0f, 15.0f * Time.deltaTime); // around z

        if (transform.rotation == Quaternion.Euler(90f, 0, 0))
        {
            ChangeColor();
        }
    }

    private void ChangeColor()
    {
        Renderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}
