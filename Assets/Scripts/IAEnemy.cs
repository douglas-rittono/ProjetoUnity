using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour
{
    public Collider2D colliderEnemy;
    public Animator animatorEnemy;
    private Rigidbody2D bodyEnemy;
    public float maxSpeed;

    public GameObject gun;
    public float shootInterval;
    private float currentTimeShoot;

    private bool motion;
    public float motionInterval;
    private float curretTimeMotion;
    public float percMotion;
    public float speedMotionX;
    public float motionDuration;

    // Start is called before the first frame update
    void Start()
    {
        bodyEnemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        float perc;
        bodyEnemy.velocity = new Vector3(speedMotionX, maxSpeed, 0);

        currentTimeShoot += Time.deltaTime;

        if (currentTimeShoot >= shootInterval)
        {
            currentTimeShoot = 0;
            gun.SendMessage("Atirar", SendMessageOptions.DontRequireReceiver);
        }

        if (!motion)
        {
            curretTimeMotion += Time.deltaTime;
            if (curretTimeMotion >= motionInterval)
            {
                curretTimeMotion = 0;
                perc = Random.Range(0, 99);
                if (perc <= percMotion)
                {
                    motion = true;
                    perc = Random.Range(0, 99);
                    if (perc < 50)
                    {
                        speedMotionX = maxSpeed * -1;
                    }
                    else
                    {
                        speedMotionX = maxSpeed;
                    }
                }
            }
        }
        else
        {
            curretTimeMotion += Time.deltaTime;
            if(curretTimeMotion >= motionDuration)
            {
                motion = false;
                speedMotionX = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "BlueShot")
        {
            colliderEnemy.enabled = false;
            animatorEnemy.SetBool("Explosao", true);
            Destroy(this.gameObject, 0.9f);
        }
        else if (col.tag == "Player")
        {
            Application.LoadLevel("LoadScene");
        }
    }

}
