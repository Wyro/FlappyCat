using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Force = 1;
    public float MyVelocity = 1;
    public Rigidbody2D MyRigidbody;
    public GameManager GameManager;

    void Start()
    {
        this.MyRigidbody.simulated = true;
        GameManager = GameManager.GetComponent<GameManager>();
    }
    
    void Update()
    {
        MovePlayer();
        AddForce();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
        GameManager.ShowUI("You have failed!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.ShowUI("Congratulations!");
    }

    public void Die()
    {
        this.gameObject.SetActive(false);
    }

    public void MovePlayer()
    {
        MyRigidbody.velocity = new Vector2(MyVelocity, MyRigidbody.velocity.y);
    }

    public void AddForce()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MyRigidbody.AddForce(transform.up * Force);
        }
    }
}
