using UnityEngine;

public class Food : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object we collided with is the player
        // This assumes the player has a tag "Player"
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("OnTriggerEnter fired");

            // Increase the score
            GameManager.instance.AddScore(10);
            
            // Destroy the food object
            Destroy(gameObject);
        }
    }
}

