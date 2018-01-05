using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //This is reference to the rigidbody componet named "rb" //add physics material to stop spinning
    public Rigidbody rb;

    public float fowardForce = 2000f; //allows force to be modified inside unity engine 
    public float sidewaysForce = 500f;
    // Update is called once per frame
	void FixedUpdate () { //unity likes fixed update when using physics
        rb.AddForce(0, 0, fowardForce * Time.deltaTime); //adds foward force

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce, 0, 0);//only excuted if condition is met
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce, 0, 0);//only excuted if condition is met
        }

    }
}
