using UnityEngine;

public class playermovment : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    public float forwardForce = 2000f;
    public float kierownica = 500f;
    public float skok = 200f;
    public float hamulec = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //dodajemy si³e
        if(Input.GetKey("d"))
        {
        rb.AddForce(kierownica * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-kierownica * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("w"))
        {
            rb.AddForce( 0, 0, kierownica* Time.deltaTime);
        }
        else if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -hamulec* Time.deltaTime);
        }
      
    }
}
