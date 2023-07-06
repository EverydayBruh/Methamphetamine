using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeJump : MonoBehaviour
{
    public float JumpSpeed = 10;
    public Rigidbody2D myRigidbody;
<<<<<<< Updated upstream
    public bool isOnGround;
=======

    [Header("Player Animation Settings")]
    public Animator animator;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
=======
        animator.SetFloat("Vertical Move", Mathf.Abs(myRigidbody.velocity.y));

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(myRigidbody.velocity.y) < 0.01)
>>>>>>> Stashed changes
        {
            myRigidbody.velocity = Vector2.up * JumpSpeed;
        }
    }
}
