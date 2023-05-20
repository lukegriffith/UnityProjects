using UnityEngine;
using TMPro; 

public class ScoreDisplay : MonoBehaviour
{

    // If using TextMeshPro
     TMP_Text scoreText;

    void Awake()
    {
         scoreText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        // Update the text to display the current score
        scoreText.text = "Score: " + GameManager.instance.score;
    }
}

