using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class BatGFX : MonoBehaviour
{

public bool isDead;

private Rigidbody2D rb;

public float speed = 5;



  public AIPath aiPath;

  void Start()
  {
      rb = GetComponent<Rigidbody2D>();
  }

void FixedUpdate()
    {
// kuolon hetki
      isDead = GetComponent<Enemy>().Isdead;
        // if alive, keep moving
      if (!isDead)
      {
          rb.velocity = new Vector2(speed, 0f);
      } 
     if (isDead)
      {
          rb.velocity = new Vector2(0f, 0f);
      } 




    }


    // Update is called once per frame
    void Update()
    {
       if(aiPath.desiredVelocity.x >= 0.01f)
       {
           transform.localScale = new Vector3(-2.5f, 2.5f, 2.5f);
       } 
       else if (aiPath.desiredVelocity.x <= -0.01f)
       {
           transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
       }
    }

       
} 



