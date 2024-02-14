using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10000f; // Adjust the speed as needed

    void Update()
    {
        // Check for input from arrow keys
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput = 1f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalInput = -1f;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalInput = 1f;
        }

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;

        // Apply movement
        transform.Translate(movement);
    }
}
