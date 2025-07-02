using UnityEngine;

public class Car_Movement : MonoBehaviour
{

    public float speed = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,speed*Time.deltaTime,0);

        if (transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }
}
