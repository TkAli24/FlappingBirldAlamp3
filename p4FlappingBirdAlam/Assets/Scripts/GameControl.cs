using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public GameObject gameOverText;
    public bool gameOver = false;
    public static GameControl instrance;
    public float scrollSpeed = -1.5f;
    public TMP_Text scoreText;

    private int score = 0;

    // Start is called before the first frame update
    void Awake()
    {
       if (instrance == null) {
            instrance = this;
            }else if (instrance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver == true && Input.GetMouseButtonDown (0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void BirdScored()
    {
        if(gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "score" + score.ToString();
    }
    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
