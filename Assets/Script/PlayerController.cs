using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRigidBody;
    private Vector2 moveDir = Vector2.zero;
    private float moveSpeed = 2f;
    public bool isHasDeathMark;
    public int nDeathMarks; 

    

    // Start is called before the first frame update
    void Awake()
    {        
        playerRigidBody = this.GetComponent<Rigidbody2D>();        
        Actions.MoveEvent += UpdateMoveVector;
        isHasDeathMark = false;
        nDeathMarks = 0; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandlePlayerMovement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Attack!");
        }

    }

    private void UpdateMoveVector (Vector2 inputVector) 
    {
        moveDir = inputVector; 
    }

    private void HandlePlayerMovement() 
    {
        playerRigidBody.MovePosition(playerRigidBody.position + moveDir * Time.fixedDeltaTime * moveSpeed);
    }

    private void OnDisable()
    {
        Actions.MoveEvent -= UpdateMoveVector; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) 
        {
            Debug.Log("Colliding with the enemy");
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Attack the enemy!");
            }
        }
    }

    public void PutDeathMark() 
    {
        if(nDeathMarks > 0) 
        {
            nDeathMarks--; 
        }
    }

}
