using UnityEngine;
using System.Collections;
public class Car_Spawner : MonoBehaviour
{
    public GameObject[] car;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnCars());  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Cars()
    {
        int rand = Random.Range(0, car.Length);
        float randXPos = Random.Range(-1.40f, +1.49f);
        Instantiate(car[rand], new Vector3(randXPos, transform.position.y, transform.position.z), Quaternion.identity);
    }
    
    IEnumerator SpawnCars()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);
            Cars();
        }
    }
}
