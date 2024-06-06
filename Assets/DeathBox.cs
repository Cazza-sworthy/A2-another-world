using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    // Reference to the respawn point GameObject
    public Transform respawnTransform;

    // Start is called before the first frame update
    void Start()
    {
        if (respawnTransform == null)
        {
        }
    }

    // This method is called when the player enters a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Debug log to check if OnTriggerEnter is called

        // Check if the player entered the trigger zone
        if (other.CompareTag("RespawnZone"))
        {
            // Debug log to confirm correct tag

            // Move the player to the respawn point
            if (respawnTransform != null)
            {
                transform.position = respawnTransform.position;
                transform.rotation = respawnTransform.rotation; // Optionally set the rotation too
            }
        }
    }
}
