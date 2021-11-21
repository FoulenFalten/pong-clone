using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityScript : MonoBehaviour
{
    float gravity = 0f;
    // Update is called once per frame
    void Update()
    {
        gravity = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}