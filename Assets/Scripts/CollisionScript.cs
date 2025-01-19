using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    private TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
        scoreText = GameObject.Find("Score").GetComponent<TMP_Text>();
        UpdateScoreText();
    }

private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (SceneManager.GetActiveScene().name == "Level2" && CompareTag("YES"))
            {
                MoveScript.score++;
                SceneManager.LoadScene("GameOver");
            }
            else if (CompareTag("YES"))
            {
                MoveScript.score++;
                SceneManager.LoadScene("Level2");
            }
            else if (CompareTag("No"))
            {
                MoveScript.score--;
                SceneManager.LoadScene("GameOver");
            }

            Destroy(gameObject);
            UpdateScoreText();
        }
    }


    void UpdateScoreText()
    {
        scoreText.text = "Score: " + MoveScript.score;
    }
}