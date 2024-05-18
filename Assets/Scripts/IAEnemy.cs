using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour
{
    public Collider2D colliderEnemy;
    public Animator animatorEnemy;
    private Rigidbody2D bodyEnemy;
    public float maxSpeed;

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
        bodyEnemy.velocity = new Vector3(0, maxSpeed, 0);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "BlueShot")
        {
            colliderEnemy.enabled = false;
            animatorEnemy.SetBool("Explosao", true);
            Destroy(this.gameObject, 0.9f);
        }else if(col.tag == "Player")
        {
            Application.LoadLevel("LoadScene");
        }        
    }
   
}
