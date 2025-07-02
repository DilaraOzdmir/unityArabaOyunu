
using UnityEngine;

public class Road_Movement : MonoBehaviour
{
    public Renderer meshRenderer;
    public float speed = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(0, speed * Time.deltaTime);
       
    }
}
