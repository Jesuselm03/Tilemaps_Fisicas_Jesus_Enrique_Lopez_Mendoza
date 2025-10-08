using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 3f;

    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); 
        float verticalInput = Input.GetAxis("Vertical");     

        Vector2 movement = new Vector2(horizontalInput, verticalInput).normalized;
        transform.Translate(movement * speed * Time.deltaTime);

        bool walking = movement.magnitude > 0.01f;
        if (animator != null)
            animator.SetBool("isWalking", walking);

        if (spriteRenderer != null && Mathf.Abs(horizontalInput) > 0.01f)
        {
            if (horizontalInput > 0.01f) spriteRenderer.flipX = true;
            else if (horizontalInput < -0.01f) spriteRenderer.flipX = false;
        }
    }
}