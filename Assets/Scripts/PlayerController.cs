using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody;

    public float upForce;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.velocity = new Vector2(0, 0);
            rigidbody.AddForce(new Vector2(0, upForce));
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player collided with " + collision.gameObject.name);
    }
}
