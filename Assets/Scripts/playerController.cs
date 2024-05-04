using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [Header("Player")]
    public Rigidbody2D playerRigidBody;
    public Transform playerTransform;
    public Animator playerAnimation;

    [Header("Speed")]
    public float maxSpeedX;
    public float maxSpeedY;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        playerRigidBody.velocity = new Vector3(movX * maxSpeedX, movY * maxSpeedY);
        playerAnimation.SetFloat("movx", movX);
       
    }
}
