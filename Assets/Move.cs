using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {


	[SerializeField]private float angular_speed = 45.0f;
    [SerializeField]private float speed = 10.0f;

    private void Update()
	{
		float horizontal = Input.GetAxis("Horizontal");
		Debug.Log(horizontal);

		float y = Input.GetAxis("Third");
		Debug.Log(y);

		float vertical = Input.GetAxis("Vertical");
		Debug.Log(vertical);

		Quaternion delta_rotation = Quaternion.Euler(new Vector3(0.0f, y * angular_speed * Time.deltaTime, 0.0f));
		transform.rotation *= delta_rotation;

		Vector3 delta_position = (transform.forward * vertical + transform.right * horizontal) * speed * Time.deltaTime;

		if (delta_position.magnitude > 1)
		{
			delta_position.Normalize();
		}
		transform.position += delta_position;


    }

}
