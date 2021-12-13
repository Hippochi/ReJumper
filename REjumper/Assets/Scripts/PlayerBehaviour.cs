using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        activeMoveSpeed = moveSpeed;

    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        if (isGrounded)
        {
            if (Input.GetAxisRaw("Horizontal") > 0f)
            {
                myRigidBody.velocity = new Vector3(x: activeMoveSpeed, y: myRigidBody.velocity.y, z: 0f);
                transform.localScale = new Vector3(1f, 1f, 1f);
            }

            else if (Input.GetAxisRaw("Horizontal") < 0f)
            {
                myRigidBody.velocity = new Vector3(x: -activeMoveSpeed, y: myRigidBody.velocity.y, z: 0f);
                transform.localScale = new Vector3(-1f, 1f, 1f);
            }

            if (Input.GetKey(KeyCode.Space) && isGrounded)
            {
                myRigidBody.velocity = new Vector3(0f, 0f, 0f);
                jumpStrength += (Time.deltaTime * multiplier);
                jumpX += (Time.deltaTime * JumpMultiplier);
            }

            if (Input.GetButtonUp("Jump") && isGrounded)
            {
                if (jumpStrength > 13)
                    jumpStrength = 13;
                if (Input.GetAxisRaw("Horizontal") > 0f)
                {
                    myRigidBody.AddForce(Vector2.right * jumpStrength, ForceMode2D.Impulse);
                    myRigidBody.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
                }
                Debug.Log("X velocity : " + myRigidBody.velocity.x);
                Debug.Log(jumpStrength);
                jumpX = 0f;
                jumpStrength = 0f;
            }
        }
    }
}
