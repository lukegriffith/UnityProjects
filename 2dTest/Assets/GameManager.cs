using UnityEngine;


public class GameManager : MonoBehaviour
{
    // Static singleton instance
    public static GameManager instance = null;
    
    // Global score
    public int score = 0;

    // Awake is called when the script instance is being loaded
    void Awake()
    {
        // Check if instance already exists
        if (instance == null)
        {
            instance = this;
        }
        // If instance exists and it's not this:
        else if (instance != this)
        {
            // Destroy this to enforce the singleton.
            Destroy(gameObject);    
        }

        // Make sure this persists between scenes
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
    }
}
