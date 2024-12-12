using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    public string targetTag = "Player"; // Tag to identify the target that triggers disappearance

    private Renderer platRend;  // Renderer component to control visibility
    private Collider2D platCollide; // Collider2D component to handle collisions

    void Start()
    {
        // Get the Renderer and Collider2D components attached to this GameObject
        platRend = GetComponent<Renderer>();
        platCollide = GetComponent<Collider2D>();

        // Ensure the platform starts as visible
        if (platRend == null || platCollide == null)
        {
            Debug.LogError("Missing Renderer or Collider2D component.");
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object that collided has the correct tag
        if (collision.gameObject.CompareTag(targetTag))
        {
            // Hide the platform
            HidePlatform();
            Debug.Log("touch");
        }
    }

    void HidePlatform()
    {
        if (platRend != null)
        {
            platRend.enabled = false; // Hide the platform's visual representation
        }
        if (platCollide != null)
        {
            platCollide.enabled = false; // Disable the platform's collider so no further collisions occur
        }
    }
}
