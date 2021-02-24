
using UnityEngine;

public class ballGreen : MonoBehaviour

{
    Vector3DMaths _vector3DMaths = new Vector3DMaths();
    private Rigidbody rb;
    public Vector3 velocity;
    public Vector3 oppositeForce;
    public Vector3 CollisonOpposingForce;
    
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.AddForce(velocity - oppositeForce, ForceMode.VelocityChange);
    }

    void OnCollisionEnter(Collision collision)
    {
        ReflectProjectile(rb, collision.contacts[0].normal);
    }

    private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
    {
        velocity = Vector3.Reflect(velocity - CollisonOpposingForce - oppositeForce, reflectVector);
        rb.velocity = velocity - oppositeForce;
    }
}
