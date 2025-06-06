using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2P_1 : MonoBehaviour
{
    //private float paddleY = -17f;
    private float xValue;
    public float speed1 = 20f;
    public GameObject leftWall;
    public GameObject middleWall;
    public Transform leftWallTransform;

    
    void Start()
    {

    }

  
    void FixedUpdate()
    {
        
        float xDirection = Input.GetAxis("Horizontal");
        //Debug.Log("xDirection: " + xDirection);
        Vector3 moveDirection = new Vector3(xDirection, 0.0f);

        
        xValue = (transform.localPosition + moveDirection * speed1 * Time.deltaTime).x + (-1 * leftWallTransform.localScale.x) + (-1 * transform.localScale.x / 2);
        if (xValue < -35 + 0.5)
        {
            Debug.Log("Player 1: out of left boundary");
        }
        else if (xValue <= 0 - 3.5 && xValue >= -35 + 0.5)
        {
            transform.localPosition += moveDirection * speed1 * Time.deltaTime;
        }
   
        else if (xValue > 0 - 3.5)
        {
            Debug.Log("Player 1: out of right boundary");
        }
        else
        {
            transform.localPosition += moveDirection * speed1 * Time.deltaTime;
        }

    }

}
