using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    GameObject Jay;
    // Start is called before the first frame update
    void Start()
    {
        Jay = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Jay.GetComponent<Movement>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Jay.GetComponent<Movement>().isGrounded = false;
        }
    }
}

