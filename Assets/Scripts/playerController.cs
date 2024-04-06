using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [Header("Player")]
    public Rigidbody2D playerRigidBody;
    public Transform playerTransform;

    [Header("Speed")]
    public float maxSpeedX;
    public float maxSpeedY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        playerRigidBody.velocity = new Vector3(movX * maxSpeedX, movY * maxSpeedY);
        
        if(movX > 0)
        {
            playerTransform.localScale = new Vector3(2, 2, 2);
        }
        else
        {
            playerTransform.localScale = new Vector3(1, 1, 1);
        }
    }
}
