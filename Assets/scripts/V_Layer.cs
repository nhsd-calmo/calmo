using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Layer : MonoBehaviour {

	V_Config config;

	public void setConfig(V_Config _config){
		config = _config;
	}

	public void animate(float size,float time){
		iTween.ScaleTo(this.gameObject, iTween.Hash("x", size, "y", size , "easetype","easeInOutExpo","time",time));
	}

}
