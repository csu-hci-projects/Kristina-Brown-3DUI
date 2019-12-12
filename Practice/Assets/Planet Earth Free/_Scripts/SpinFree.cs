using UnityEngine;
using System.Collections;

/// <summary>
/// Spin the object at a specified speed
/// </summary>
public class SpinFree : MonoBehaviour {
	[Tooltip("Spin: Yes or No")]
	public bool spin;
	[Tooltip("Spin the parent object instead of the object this script is attached to")]
	public bool spinParent;
	private float speed = 10f;

	[HideInInspector]
	public bool clockwise = true;
	[HideInInspector]
	public float direction = 1f;
	[HideInInspector]
	public float directionChangeSpeed = 2f;

    private void Start()
    {
        Debug.Log("Called Start");
    }
    // Update is called once per frame
    void Update() {

        if (spinParent)
        {
            if (Input.GetKey(KeyCode.A) && clockwise==true) //This works by getting the key, no need to have a separate key to stop it.
            {
                //Clockwise
                //Debug.Log("A key was pressed.");
               transform.Rotate(Vector3.up, speed * direction * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                
                Debug.Log("D key was pressed.");
                transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.W))
            {
                speed += 1;
                Debug.Log("increase" + speed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                speed -= 1;
                Debug.Log("decrease" + speed);
            }
        }
            
            if (direction < 1f)
            {
                direction += Time.deltaTime / (directionChangeSpeed / 2);
            }
        

	//	if (spin) {
	//		if (clockwise) {
	//			if (spinParent)
	//				transform.parent.transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime);
	//			else
	//				transform.Rotate(Vector3.up, (speed * direction) * Time.deltaTime);
	//		} else {
	//			if (spinParent)
	//				transform.parent.transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime);
	//			else
	//				transform.Rotate(-Vector3.up, (speed * direction) * Time.deltaTime);
	//		}
	//	}
	}
}