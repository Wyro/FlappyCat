using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Force = 1;
    public float MyVelocity = 1;
    public Rigidbody2D myRigidbody;
    public GameObject EndingUI;

    void Start()
    {
        this.myRigidbody.simulated = true;
    }
    
    void Update()
    {
        MovePlayer();
        AddForce();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
        EndingUI.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EndingUI.SetActive(true);
    }

    public void Die()
    {
        Debug.Log("You died");
        this.gameObject.SetActive(false);
    }

    public void MovePlayer()
    {
        myRigidbody.velocity = new Vector2(MyVelocity, myRigidbody.velocity.y);
    }

    public void AddForce()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myRigidbody.AddForce(transform.up * Force);
        }
    }
}
