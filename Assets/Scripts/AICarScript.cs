using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AICarScript : MonoBehaviour {


    public Vector3 centerOfMass;
	private List<Transform> path;
    public Transform pathGroup;
	
    public float maxSteer = 23;

    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public WheelCollider wheelRL;
    public WheelCollider wheelRR;
	
    public int currentPathObj = 32;
    public float distFromPath = 10;
    public float maxTorque = 1000;
    public float currentSpeed;
    public float topSpeed = 180;
    public float decelerationSpeed = 30;
	public bool isBraking;
	public bool inSector;
    public float slopeTorque = 15;
    
	private Rigidbody rb;
    
    void Start()
    {
        path = new List<Transform>();
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = centerOfMass;
        getPath();
    }

  

    void getPath()
    {
        Transform[] childObjects = pathGroup.GetComponentsInChildren<Transform>();

        for (int i = 0; i < childObjects.Length; i++)
        {
            Transform temp = childObjects[i];
            if (temp.gameObject.GetInstanceID() != GetInstanceID())
                path.Add(temp);
        }

    }
	
  void Update()
    {
        getSteer();
        Move();
    }
	
    void getSteer()
    {
        Vector3 steerVector = transform.InverseTransformPoint(new Vector3(path[currentPathObj].position.x, transform.position.y, path[currentPathObj].position.z));
        float newSteer = maxSteer * (steerVector.x / steerVector.magnitude);
        wheelFL.steerAngle = newSteer;
        wheelFR.steerAngle = newSteer;

        if (steerVector.magnitude <= distFromPath)
        {
            currentPathObj++;
			if (currentPathObj >= path.Count)
			{
				currentPathObj = 0;
			}
		}
		if((wheelFL.transform.position.z > wheelRR.transform.position.z) && (wheelRL.transform.position.z > wheelFR.transform.position.z))
		{
            wheelRL.motorTorque = (maxTorque/slopeTorque);
            wheelRR.motorTorque = (maxTorque/slopeTorque);
			Debug.Log("slope");
		}
    }

    void Move()
    {
        currentSpeed = 2 * (22 / 7) * wheelRL.radius * wheelRL.rpm * 60 / 1000;
        currentSpeed = Mathf.Round(currentSpeed);
		Debug.Log(wheelRL.motorTorque);
		Debug.Log(wheelRR.motorTorque);
        if (currentSpeed <= topSpeed )
        {
            wheelRL.motorTorque = maxTorque;
            wheelRR.motorTorque = maxTorque;
            wheelRL.brakeTorque = 0;
            wheelRR.brakeTorque = 0;
        }
        else 
        {
            wheelRL.motorTorque = 0;
            wheelRR.motorTorque = 0;
            wheelRL.brakeTorque = decelerationSpeed;
            wheelRR.brakeTorque = decelerationSpeed;
        }		

    }


}