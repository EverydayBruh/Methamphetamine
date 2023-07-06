using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlimeJump : MonoBehaviour
{
    public float JumpSpeed = 10;
    public Rigidbody2D myRigidbody;
    public bool isOnGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            myRigidbody.velocity = Vector2.up * JumpSpeed;
            isOnGround = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }
}
