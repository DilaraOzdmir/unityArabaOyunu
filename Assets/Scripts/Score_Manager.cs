using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Score());
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }


    IEnumerator Score() 
    {
        while (true)
        {
            yield return new WaitForSeconds(0.8f);
            score = score + 1;
            Debug.Log(score);
        }
    }
}

