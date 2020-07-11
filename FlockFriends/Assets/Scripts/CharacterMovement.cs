using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Vector3 moveLeft = new Vector3(-1, 0, 0);
    Vector3 moveRight = new Vector3(1, 0, 0);
    GameObject Player;
    PlayerMovement playerMovement;

    public float characterSpeed;


    bool isAvoid;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        playerMovement = Player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            if(collision.gameObject.transform.position.x > gameObject.transform.position.x)
            {
                Debug.Log("MovingLeft");
                StartCoroutine(MoveLeft());
            }
            else
            {
                Debug.Log("Moving Right");
                StartCoroutine(MoveRight());
            }
        }
        


    }
    
    IEnumerator MoveRight()
    {
        transform.position += moveRight * playerMovement.speed * characterSpeed * Time.fixedDeltaTime;

        yield return new WaitForSeconds(1f);

        transform.position += moveLeft * playerMovement.speed * characterSpeed * Time.fixedDeltaTime;

        yield return new WaitForSeconds(1f);
    }

    IEnumerator MoveLeft()
    {
        transform.position += moveLeft * playerMovement.speed * characterSpeed * Time.fixedDeltaTime;

        yield return new WaitForSeconds(1f);

        transform.position += moveRight * playerMovement.speed * characterSpeed * Time.fixedDeltaTime;

        yield return new WaitForSeconds(1f);
    }
    
}
