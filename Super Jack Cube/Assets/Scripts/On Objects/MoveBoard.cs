using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoard : MonoBehaviour
{
    // Update is called once per frame
    //Variables
    public int speed = 1;
    //private Rigidbody boardRigidBody;
    void Update()
    {
        //Key commands
        
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))//Up
        {
            //Rotate on the z
            transform.Rotate(new Vector3(0, 0, speed) * Time.deltaTime);
           
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))//Left
        {
            //Rotate on the x
            transform.Rotate(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))//Down
        {
            //Rotate on the z
            transform.Rotate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))//Right
        {
            //Rotate on the x
            transform.Rotate(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Delete) || Input.GetKey(KeyCode.Q))//Turn Left
        {
            //Rotate on the y
            transform.Rotate(new Vector3(0, -speed, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.PageDown) || Input.GetKey(KeyCode.E))//Turn Right
        {
            //Rotate on the y
            transform.Rotate(new Vector3(0, speed, 0) * Time.deltaTime);
        }
    }
}
