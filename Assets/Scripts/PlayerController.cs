using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Force = 1;
    public float MyVelocity = 1;
    public Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        AddForce();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You died");
        Die();
    }

    public void Die()
    {
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
