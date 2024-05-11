using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [Header("Player")]
    public Rigidbody2D playerRigidBody;
    public Transform playerTransform;
    public Animator playerAnimation;
    public GameObject armaTripla;
    public GameObject armaQuintupla;

    [Header("Speed")]
    public float maxSpeedX;
    public float maxSpeedY;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimation = GetComponent<Animator>();
        armaTripla.SetActive(false);
        armaQuintupla.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        playerRigidBody.velocity = new Vector3(movX * maxSpeedX, movY * maxSpeedY);
        playerAnimation.SetFloat("movx", movX);

        if (Input.GetButtonDown("Jump"))
        {
            if (!armaTripla.activeSelf)
            {
                armaTripla.SetActive(true);
            }else if (!armaQuintupla.activeSelf)
            {
                armaQuintupla.SetActive(true);
            }
            else
            {
                armaTripla.SetActive(false);
                armaQuintupla.SetActive(false);
            }
        }
    }
}
