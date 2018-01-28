using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_BallSway : MonoBehaviour {

	public float amount;
	public float maxAmount;
	public float smoothAmount;

	private Vector3 initialPos;

	// Use this for initialization
	void Start () {
		initialPos = transform.localPosition;	
	}
	
	// Update is called once per frame
	void Update () {
		float movX = Input.GetAxis("Mouse X") * amount;
		float movY = Input.GetAxis("Mouse Y") * amount;

		movX = Mathf.Clamp(movX,-maxAmount,maxAmount);
		movY = Mathf.Clamp(movY,-maxAmount,maxAmount);

		Vector3 finalPos = new Vector3(movX,movY,0);
		transform.localPosition = Vector3.Lerp(transform.localPosition, finalPos + initialPos, Time.deltaTime * smoothAmount);
	}
	
}