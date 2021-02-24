
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    //speed that can be edited in unity to control speed of the ball
    public float speed;
    
    //radius for go around the cylinder 
    public float radius;
    
    //array to store objects
    public Transform[] wpArray;
    
    //current waypoint value is stored in this var
    private int currentWaypointNo;
    
    //using the pre created vector maths library
    Vector3DMaths vector3DMaths = new Vector3DMaths();
 
    // when starting waypoint no is zero
    void Start()
    {
        currentWaypointNo = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //updating the direction of the ball with pre created maths library
        Vector3 direction = vector3DMaths.unitDirectionVector(wpArray[currentWaypointNo].transform.position, this.transform.position);
        
        Vector3 vel = vector3DMaths.getScalerMultiplic(direction, speed);
        
        Vector3 velTimesDeltaT = vector3DMaths.getScalerMultiplic(vel, Time.deltaTime);
        //positioning
        this.transform.position = vector3DMaths.addVectors(transform.position, velTimesDeltaT);

    }

// when collided with a cylinder waypoint length will be increased by one
     void OnCollisionEnter(Collision collision)
    {
        if (currentWaypointNo != wpArray.Length -1)
        {
          
            currentWaypointNo++;
        }
        else
        {
            currentWaypointNo = 0;
        }
    }
}
