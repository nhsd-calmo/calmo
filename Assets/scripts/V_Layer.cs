using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Layer : MonoBehaviour {

	public float breatheInSize;
	public float breatheInHoldSize;
	public float breatheOutSize;
	public float breatheOutHoldSize;

	public float breatheInTime;
	public float breatheInHoldTime;
	public float breatheOutTime;
	public float breatheOutHoldTime;

	private float size;
	private float time;
	private string easeType;

	public void animate(int state){

		switch(state){
			case 0:
			size = breatheInSize;
			time = breatheInTime;
			easeType = "easeOutExpo";
			break;
			case 1:
			size = breatheInHoldSize;
			time = breatheInHoldTime;
			easeType = "linear";
			break;
			case 2:
			size = breatheOutSize;
			time = breatheOutTime;
			easeType = "easeInOutExpo";
			break;
			case 3:
			size = breatheOutHoldSize;
			time = breatheOutHoldTime;
			easeType = "linear";
			break;
		}

		iTween.ScaleTo(this.gameObject, iTween.Hash("x", size, "y", size , "easetype","easeInOutExpo","time",time));
		
	}

	public void manualAnimation(float _size,float _time){

		iTween.ScaleTo(this.gameObject, iTween.Hash("x", _size, "y", _size , "easetype","easeInOutExpo","time",_time));

	}

}
