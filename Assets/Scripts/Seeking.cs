using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Seeking : MonoBehaviour
{

    private Rigidbody rb;
    private bool isseeking;
    private Vector3 velocity;
    private Vector3 force;

    public float max_velocity;
    public GameObject target;
    


    void Start ()
    {
        //to make seeker stop once target is reached
        isseeking = true;
        //sets up the default velocity and force, position is already decided in unity
        velocity = new Vector3(0, 0, 0);
        force = new Vector3(0, 0, 0);
	}
	
    //void Seek()
    //{
    //
    //}


    // Can be way improved
	void Update ()
    {
        if (velocity.x <= max_velocity && velocity.y <= max_velocity && velocity.z <= max_velocity)
        {
            Vector3 displacement = target.transform.position - transform.position;
            Vector3 distVector = displacement * max_velocity;
            Vector3 seekForce = distVector - velocity;
            force = seekForce;
            velocity += force * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;
        }
    }
}
