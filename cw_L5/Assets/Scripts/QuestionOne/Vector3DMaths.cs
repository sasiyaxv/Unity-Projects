
using UnityEngine;

public class Vector3DMaths : MonoBehaviour
{
    void Start()
    {
    }
    
    void Update()
    {
    }

//3D Vector Maths Library
    //method to add Vectors. this method will return the addition of two vector3

    public Vector3 addVectors(Vector3 v1, Vector3 v2)
    {
        Vector3 result;
        result.x = v1.x + v2.x;
        result.y = v1.y + v2.y;
        result.z = v1.z + v2.z;
        return result;
    }


    //method to subtract Vectors.this method will return the substraction of two vector3
    public Vector3 subtractVectors(Vector3 v1, Vector3 v2)
    {
        Vector3 result = new Vector3();
        result.x = v1.x - v2.x;
        result.y = v1.y - v2.y;
        result.z = v1.z - v2.z;
        return result;
    }


    //method to get dot product of Vectors.this method will return the dot product of two vector3
    public double dotProductVectors(Vector3 vec1, Vector3 vec2)
    {
        double result = vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z;
        return result;
    }
    
    // this method will return the magnitude of a vector3
   public float getMagnitude(Vector3 vec)
    {
        float magnitude = Mathf.Sqrt(Mathf.Pow(vec.x, 2) + Mathf.Pow(vec.y, 2) + Mathf.Pow(vec.z, 2));
        return magnitude;
    }


    //method to get the unit vector of a Vector
    //unitVector = vector/magnitude of the vector
    public Vector3 unitVector(Vector3 v1)
    {
        Vector3 result = new Vector3();

        float magnitude = getMagnitude(v1);

        result.x = v1.x / magnitude;
        result.y = v1.y / magnitude;
        result.z = v1.z / magnitude;

        return result;
    }


    //method to get reflection of a Vector
    public Vector3 vectorReflection(Vector3 v1)
    {
        Vector3 result = new Vector3();
       
        return result;
    }


    //method to convert a Vector to polar to cartesian
    public Vector2 polarToCartesian(float r,float theta)
    {
         Vector2 result = new Vector2();
         float y1 = Mathf.Sin(theta) * r;
         float x1 = Mathf.Cos(theta) * r;
         result.x = x1;
         result.y = y1;
         return result;
        
    }


    // method to convert a Vector to cartesian to polar 
    public  Vector2 cartesianToPolar(float x,float y)
    {
        Vector2 result = new Vector2();
    
        float r = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
        float theta = Mathf.Tan(Mathf.Atan2(y, x));
        result.x = r;
        result.y = theta;
        return result;
    }

    //method to get unit direction vector 
    public Vector3 unitDirectionVector(Vector3 v1, Vector3 v2)
    {
        Vector3 result = new Vector3();
        result = subtractVectors(v1, v2);
        float magnitude = getMagnitude(result);
        result.x = result.x / magnitude;
        result.y = result.y / magnitude;
        result.z = result.z / magnitude;
        return result;
    }
    
    //this method will return a vector multiplied by a scalar 

    public Vector3 getScalerMultiplic(Vector3 v1, float scalar)
    {
        Vector3 result = new Vector3();
        result.x = v1.x * scalar;
        result.y = v1.y * scalar;
        result.z = v1.z * scalar;
        return result;
    }

//this method will find out if two vectors are equal or not
    public bool vectorEqual(Vector3 vec1, Vector3 vec2)
    {
        bool flag = false;
        if (vec1 == vec2)
        {
            flag = true;
        }
        return flag;
    }

    // method to return a zero 3d vector
    public Vector3 zeroVector()
    {
        Vector3 result = new Vector3(0f, 0f, 0f);
        return result;
    }
    
    // this method will find out if a point is on a line or not
    public bool pointOnLine(double m,double c ,double x,double y)
    {
        bool flag = false;
        if (y == ((m * x) + c))
        {
            flag =  true;
        }

        return flag;
    }
}
