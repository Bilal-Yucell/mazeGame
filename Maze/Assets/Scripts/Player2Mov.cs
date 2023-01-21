using UnityEngine;
using TMPro;

public class Player2Mov : MonoBehaviour
{

    public float force = 20f;

    // public bool canMove=true;

    public Rigidbody rb;


    void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            rb.AddForce(force * 1 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            // rb.velocity = new Vector3(force,0,0);
            // canMove = false;
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-force * 1 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            // canMove = false;
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, force * 1 * Time.deltaTime, ForceMode.VelocityChange);
            // canMove = false;
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -force * 1 * Time.deltaTime, ForceMode.VelocityChange);
            // canMove = false;
        }

    }

    /* private void OnTriggerEnter(Collider other)
    {
        
    } */

    /* private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Wall")
        {
            canMove = true;
        }
    } */

}
