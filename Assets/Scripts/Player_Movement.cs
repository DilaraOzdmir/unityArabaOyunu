using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float speed = 1f;
    private float screenWidth;

    public GameObject gameOverPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1;
        gameOverPanel.SetActive(false);
        screenWidth = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Stationary)
            {
                if(touch.position.x > screenWidth / 2)
                {
                    transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

                }
                if (touch.position.x < screenWidth / 2)
                {
                    transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

                }
            }

        }
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -1.40f, +1.49f);
        transform.position = pos;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag== "Car")
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);

        }
    }

}
