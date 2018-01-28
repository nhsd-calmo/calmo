using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Text : MonoBehaviour {
	
	public TextMesh textComp;
	
	public void setText(string message){
		textComp.text = message;
	}
}
