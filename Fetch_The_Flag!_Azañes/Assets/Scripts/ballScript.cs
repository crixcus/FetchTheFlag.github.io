using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public float baseJump = 4f;
    public float maxJump = 15f;
    public float chargeRate = 5f;
    public float jumpCD = 0.07f;
    public float moveSpeed = 6f;
    public LayerMask groundLayer;

    private float currentJump;
    private bool isCharging;
    private bool canJump;
    private bool isGrounded;
    private Rigidbody2D rb;

    Audio_ sfx;

    private void Awake()
    {
        sfx = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio_>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canJump = true;
        currentJump = baseJump;
    }

    void Update()
    {
        isGrounded = Physics2D.IsTouchingLayers(GetComponent<Collider2D>(), groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && canJump)
        {
            StartCharging();
        }
        if (Input.GetKeyUp(KeyCode.Space) && isCharging)
        {
            Jump();
        }
        if (isCharging)
        {
            Charge();
        }

        float moveInput = 0f;
        if (Input.GetKey(KeyCode.A))
        {
            moveInput = -1f; 
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveInput = 1f; 
        }

        Vector2 movement = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        rb.velocity = movement;

    }

    void StartCharging()
    {
        isCharging = true;
    }

    void Charge()
    {
        if (isCharging)
        {
            currentJump += (chargeRate*2) * Time.deltaTime;
            currentJump = Mathf.Clamp(currentJump, baseJump, maxJump);
        }
    }

    void Jump()
    {
        isCharging = false;
        canJump = false;
        rb.AddForce(Vector2.up * currentJump, ForceMode2D.Impulse);
        currentJump = baseJump;
        Invoke(nameof(ResetJump), jumpCD);
    }

    void ResetJump()
    {
        canJump = true;
    }
}
