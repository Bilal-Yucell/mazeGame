using UnityEngine;
using TMPro;

public class PlayerMov : MonoBehaviour
{

    public float force = 20f;

    // public bool canMove=true;

    public Rigidbody rb;


    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(force * 1 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            // rb.velocity = new Vector3(force,0,0);
            // canMove = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-force * 1 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            // canMove = false;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, force * 1 * Time.deltaTime, ForceMode.VelocityChange);
            // canMove = false;
        }

        if (Input.GetKey(KeyCode.DownArrow))
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
