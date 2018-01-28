using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {

	private V_Pattern patternComp;
	
	// Use this for initialization
	void Start () {
		patternComp = GetComponentInChildren<V_Pattern>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void startBreathing(){
		// patternConfig = new PatternConfig(10,10);
		patternComp.startBreathing();
	}
}
