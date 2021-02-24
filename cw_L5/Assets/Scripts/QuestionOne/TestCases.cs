using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCases : MonoBehaviour

{
    Vector3DMaths vector3DMaths = new Vector3DMaths();

    private  Vector3 vecOne = new Vector3(2.0f,5.0f,6.0f);
    private  Vector3 vecTwo = new Vector3(8.2f,4.0f,5.5f);
   
    private  Vector3 vec1 = new Vector3(2.0f,5.0f,6.0f);
    private  Vector3 vec2 = new Vector3(2.0f,5.0f,6.0f);

    // Start is called before the first frame update
    void Start()
    {
        // all test cases for Vetor3d maths library
        
        Debug.Log("Vector Addition");
       Debug.Log("The result vector is "+vector3DMaths.addVectors(vecOne,vecTwo));
       
       Debug.Log("Vector Subtraction");
       Debug.Log("The result vector is "+vector3DMaths.subtractVectors(vecOne,vecTwo));
       
       Debug.Log("Vector Dot product");
       Debug.Log("The result vector is "+vector3DMaths.dotProductVectors(vecOne,vecTwo));
       
       Debug.Log("Vector Magnitude");
       Debug.Log("The result vector is "+vector3DMaths.getMagnitude(vecOne));
       
       Debug.Log("Unit Vector");
       Debug.Log("The result vector is "+vector3DMaths.unitVector(vecOne));
       
       Debug.Log("Unit direction vector");
       Debug.Log("The result vector is "+vector3DMaths.unitDirectionVector(vecOne,vecTwo));
       
       Debug.Log("Unit direction vector");
       Debug.Log("The result vector is "+vector3DMaths.getScalerMultiplic(vecOne,5));

       Debug.Log("Polar to Cartesian");
       Debug.Log("The result vector is "+vector3DMaths.polarToCartesian(4.1f,5.2f));
       
       Debug.Log("Vector equality");
       Debug.Log("Result  is "+vector3DMaths.vectorEqual(vec1,vec2));
       
       Debug.Log("Zero Vector");
       Debug.Log("Result  is "+vector3DMaths.zeroVector());
       
       Debug.Log("Point on Line Check");
       Debug.Log("Result  is "+vector3DMaths.pointOnLine(2,3,1,5));

       
       Debug.Log("Cartesian to polar");
       Debug.Log("Result is"+vector3DMaths.cartesianToPolar(5,5));

       
    }
    void Update()
    {
        
        
    }
    
}
