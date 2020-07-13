using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Transform playerModel;
    public Transform sideCharacter1;
    public Transform sideCharacter2;
    public Transform sideCharacter3;
    public Vector2 playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        if(playerModel.rotation.eulerAngles.z == -45)
        {
            RotateLeft(playerModel, sideCharacter1, sideCharacter2, sideCharacter3);
        }
        else if(playerModel.rotation.eulerAngles.z == 45)
        {
            RotateRight(playerModel, sideCharacter1, sideCharacter2, sideCharacter3);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        playerMovement.x = Input.GetAxisRaw("Horizontal");
        playerMovement.y = 0;

        rb.MovePosition(rb.position + (playerMovement * speed * Time.fixedDeltaTime));

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            RotateRight(playerModel, sideCharacter1, sideCharacter2, sideCharacter3);
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            RotateLeft(playerModel, sideCharacter1, sideCharacter2, sideCharacter3);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RotateLeft(playerModel, sideCharacter1, sideCharacter2, sideCharacter3);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            RotateRight(playerModel, sideCharacter1, sideCharacter2, sideCharacter3);
        }
        
        
    }

    void RotateLeft(Transform alfanso, Transform pengo, Transform ostar, Transform turts)
    {
        alfanso.Rotate(Vector3.forward * 45);
        pengo.Rotate(Vector3.forward * 45);
        ostar.Rotate(Vector3.forward * 45);
        turts.Rotate(Vector3.forward * 45);
    } 

    void RotateRight(Transform alfanso, Transform pengo, Transform ostar, Transform turts)
    {
        alfanso.Rotate(Vector3.forward * -45);
        pengo.Rotate(Vector3.forward * -45);
        ostar.Rotate(Vector3.forward * -45);
        turts.Rotate(Vector3.forward * -45);
    }
}
