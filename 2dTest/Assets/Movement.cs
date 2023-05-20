using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // The speed at which the sprite moves
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        // Get the current position of the sprite
        Vector3 currentPosition = transform.position;

        // Calculate the new position based on the input or any other logic
        Vector3 newPosition = currentPosition + new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f) * moveSpeed * Time.deltaTime;

        // Update the position of the sprite
        transform.position = newPosition;
    }
}
