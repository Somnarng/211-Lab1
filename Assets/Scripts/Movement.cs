using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
	public CharacterController CC;
	public float MoveSpeed;
	public float Gravity = -9.8f;
	public float MouseSensitivity;
	public Transform CamTransform;
	public float verticalSpeed;

	private float camRotation = 0f;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
	}
    private void Update()
	{
		Vector3 movement = Vector3.zero;

		// X/Z movement
		float forwardMovement = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
		float sideMovement = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;

		movement += (transform.forward * forwardMovement) + (transform.right * sideMovement);

		verticalSpeed += (Gravity * Time.deltaTime);
		movement += (transform.up * verticalSpeed * Time.deltaTime);

		CC.Move(movement);

		//Camera
		float mouseInputY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;
		camRotation -= mouseInputY;
		camRotation = Mathf.Clamp(camRotation, -90f, 90f);
		CamTransform.localRotation = Quaternion.Euler(camRotation, 0f, 0f);

		float mouseInputX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
		transform.rotation = Quaternion.Euler(transform.eulerAngles + new Vector3(0f, mouseInputX));


	}
}
