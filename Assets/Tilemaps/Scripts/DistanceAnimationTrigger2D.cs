using UnityEngine;

public class DistanceAnimationTrigger2D : MonoBehaviour
{
    private float activationDistance = 5f;
    private float distanceTraveled = 0f;     
    private Vector2 lastPosition;             
    private Animator animator;
    private bool triggered = false;          

    void Start()
    {
        lastPosition = new Vector2(transform.position.x, transform.position.y);
        animator = GetComponent<Animator>(); 
    }

    void Update()
    {
        if (triggered) return;

        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);

        float distanceThisFrame = Vector2.Distance(currentPosition, lastPosition);
        distanceTraveled += distanceThisFrame;

        lastPosition = currentPosition;

        if (distanceTraveled >= activationDistance)
        {
            animator.SetTrigger("ReachedDistance");
            triggered = true;
        }
    }
}