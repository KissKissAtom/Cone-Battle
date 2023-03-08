using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControl2 : MonoBehaviour
{
    public float torque;
	Vector2 startPos, endPos, direction;
	float touchTimeStart, touchTimeFinish, timeInterval;

	[SerializeField]
	float throwForceInX = 1f;

    [SerializeField]
    float throwForceInY = 1f;

	[SerializeField]
	float throwForceInZ = 1f;

	Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount>0 && Input.GetTouch (0).phase == TouchPhase.Began){

        	touchTimeStart = Time.time;
        	startPos = Input.GetTouch (0).position;
        }

        if(Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended){

        	touchTimeFinish = Time.time;

        	timeInterval = touchTimeFinish - touchTimeStart;

        	endPos = Input.GetTouch (0).position;

        	direction = startPos - endPos;

        	rb.isKinematic = false;
        	rb.AddForce(-direction.x * throwForceInX, -direction.y * throwForceInY, throwForceInZ/timeInterval);
           
            //float turn = Input.GetAxis("Vertical");
            rb.AddTorque(Vector2.right * torque*throwForceInZ);
            
             GetComponent<SwipeControl2>().enabled = false;
             
        
        }
       // Destroy (gameObject,5f);
        //GetComponent<SwipeControl1>().enabled = false;
    }

    
}
