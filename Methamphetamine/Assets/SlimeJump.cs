using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeJump : MonoBehaviour
{
    public float JumpSpeed = 10;
    public Rigidbody2D myRigidbody;
    private bool IsAlive = true;

    [Header("Player Animation Settings")]
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Vertical Move", Mathf.Abs(myRigidbody.velocity.y));

        if (IsAlive && Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(myRigidbody.velocity.y) < 0.01)
        {
            myRigidbody.velocity = Vector2.up * JumpSpeed;
        }
    }

    public void death()
    {
        IsAlive= false;
        myRigidbody.velocity = Vector2.zero;
        myRigidbody.angularVelocity = 1000;
        animator.enabled= false;
        
    }
}
