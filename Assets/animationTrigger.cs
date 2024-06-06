using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    // Reference to the Animator component
    public Animator playerAnimator;
    // Name of the trigger parameter in the Animator
    public string animationTriggerName = "PlayAnimation";
    // Duration of the animation (optional, if known)
    public float animationDuration = 2.0f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Set the trigger to start the animation
            playerAnimator.SetTrigger(animationTriggerName);

            // Optionally, reset the trigger after the animation duration
            StartCoroutine(ResetAnimationTrigger(animationDuration));
        }
    }

    private IEnumerator ResetAnimationTrigger(float delay)
    {
        yield return new WaitForSeconds(delay);
        // Reset the animation by setting the trigger to false or transitioning back to the default state
        playerAnimator.ResetTrigger(animationTriggerName);
        playerAnimator.Play("IdleState"); // Replace "IdleState" with the name of your default state
    }
}
