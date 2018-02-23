using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour {
    float movespeed;
    Rigidbody rb;
    Vector3 velocity;
    // Use this for initialization
    void Start()
    {
        movespeed = 20f;
        Stickyboi();
        velocity = new Vector3(0,0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(velocity * movespeed * Time.deltaTime);
        bounds();
    }

    private void OnCollisionEnter(Collision col)
    {
            velocity = Vector3.Reflect(velocity, col.contacts[0].normal);
    }
    private void OnTriggerEnter(Collider other)
    {
        velocity = new Vector3(transform.position.x - other.gameObject.GetComponent<Paddle>().transform.position.x,1,0);
        velocity.Normalize();
    }
    public void Stickyboi()
    {
        this.transform.parent = FindObjectOfType<Paddle>().transform;
    }
    public void UnStick()
    {
        if (transform.parent != null)
        {
            transform.parent.DetachChildren();
            velocity = new Vector3(0, 1, 0);  
        }
    }
    public void bounds()
    {
        if(transform.position.y < -9)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    
}
