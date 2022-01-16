using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Gun[] guns;


    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    bool shoot;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        guns = transform.GetComponentsInChildren<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
       float directionY = Input.GetAxisRaw("Vertical");
       playerDirection = new Vector2(0,directionY).normalized; 
       shoot = Input.GetKeyDown(KeyCode.LeftControl);
       if (shoot)
       {
         shoot = false;
           foreach(Gun gun in guns)
           {
               gun.Shoot();
           }
       }
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0,playerDirection.y*playerSpeed);
    }
}
