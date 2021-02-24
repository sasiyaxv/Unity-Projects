
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //gravity vector to simulate gravity
    private Vector3 gravityVector = new Vector3(0,-1 * 9.81f,0);
    
    //initial launching value (Vector3) for ball. This can be set in design time
    public Vector3 LaunchVel;
    
    //Coefficient of restitution. This is used to control the ball bounce
    public float e;
    
    //position vector for ball. This will be updated when starting the program.
    private Vector3 positionVector;
    
    //velocity of the ball
    private Vector3 velocityOfBall;
    // Start is called before the first frame update
    void Start()
    {
       
        velocityOfBall = LaunchVel;
        //updating the position vector
        positionVector = this.transform.position;
    }
    
 // using fixed update 
    void FixedUpdate()
    {

       //updating the position(simulates s = ut+1/2*a*t*t)
        positionVector.y = positionVector.y + velocityOfBall.y * Time.deltaTime + 0.5f * gravityVector.y * Time.deltaTime * Time.deltaTime;
        
        //if ball have a position > 0 this will be executed.. ball will be using gravity vec
        if (positionVector.y >= 0)
        {
            //updating positions for each value(using)
            velocityOfBall.y = velocityOfBall.y + gravityVector.y * Time.deltaTime;
            
            this.transform.position = positionVector;
            
            //updating positions for each value -x 
            positionVector.x = positionVector.x + velocityOfBall.x * Time.deltaTime;
            //updating positions for each value -z 
            positionVector.z = positionVector.z + velocityOfBall.z * Time.deltaTime;
         
        }
        else 
        {
            //reversing the velocity of the ball..since e < 1 height will be different than first value
            velocityOfBall.y = -1 * e * velocityOfBall.y;
            
        }
    }
}