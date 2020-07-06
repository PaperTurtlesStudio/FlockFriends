using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Transform playerModel;
    public Vector2 playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        if(playerModel.rotation.eulerAngles.z == -45)
        {
            playerModel.Rotate(Vector3.forward * 45);
        }
        else if(playerModel.rotation.eulerAngles.z == 45)
        {
            playerModel.Rotate(Vector3.forward * -45);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        playerMovement.x = Input.GetAxisRaw("Horizontal");
        playerMovement.y = 0;



        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerModel.Rotate(Vector3.forward * -45);
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            playerModel.Rotate(Vector3.forward * 45);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerModel.Rotate(Vector3.forward * 45);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            playerModel.Rotate(Vector3.forward * -45);
        }
        
        rb.MovePosition(rb.position + (playerMovement * speed * Time.fixedDeltaTime));
    }
}
