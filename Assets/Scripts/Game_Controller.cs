using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Game_Controller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
