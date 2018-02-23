using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        Destroy(this.gameObject);
        FindObjectOfType<Paddle>().Score();
    }
}
