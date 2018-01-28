using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Pattern : MonoBehaviour {

	public GameObject layerZeroObj;
	public GameObject layerOneObj;
	public GameObject layerTwoObj;
	public GameObject layerThreeObj;
	public GameObject layerFourObj;
	public GameObject textObj;
	public float intervalTime;
	
	public int state;

	// Use this for initialization
	void Start () {
		StartCoroutine(waiter());
		intervalTime = 4f;//for kicks
		state = 0;
	}

	IEnumerator waiter()
	{
		V_Text textComp = textObj.GetComponent<V_Text>();
		AudioSource sound = GetComponentInChildren<AudioSource>();
		//Rotate 90 deg
		textComp.setText("Hello welcome to Calmo.");
		
		iTween.ScaleTo(this.layerZeroObj, iTween.Hash("x", 1, "y", 1 , "easetype","easeInOutExpo","time",2));
		iTween.ScaleTo(this.layerOneObj, iTween.Hash("x", 1.2, "y", 1.2, "easetype","easeInOutExpo","time",2.1));
		iTween.ScaleTo(this.layerTwoObj, iTween.Hash("x", 1.2, "y", 1.2, "easetype","easeInOutExpo","time",2.1));
		iTween.ScaleTo(this.layerThreeObj, iTween.Hash("x", 1.2, "y", 1.2, "easetype","easeInOutExpo","time",2.1));
		iTween.ScaleTo(this.layerFourObj, iTween.Hash("x", 1.2, "y", 1.2, "easetype","easeInOutExpo","time",2.1));
	
		yield return new WaitForSeconds(5);

		textComp.setText("Calmo helps to synchronize \n breathing by displaying an easy to follow pattern.");

		yield return new WaitForSeconds(5);

		textComp.setText("As the pattern expands breathe in.");
		InvokeRepeating("startBreathing", 0f, intervalTime);
		sound.Play();

		yield return new WaitForSeconds(4);

		textComp.setText("And Hold your breathe.");
				
		yield return new WaitForSeconds(4);

		textComp.setText("Breathe out.");

		yield return new WaitForSeconds(4);
		
		textComp.setText("Keep it out.");

		yield return new WaitForSeconds(4);

		textComp.setText("Breathe in.");

		yield return new WaitForSeconds(4);

		textComp.setText("Hold.");

		yield return new WaitForSeconds(4);

		textComp.setText("Breathe out.");

		yield return new WaitForSeconds(4);

		textComp.setText("Keep following the pattern.");

		yield return new WaitForSeconds(4);

		textComp.setText("Breathe in.");

		yield return new WaitForSeconds(4);
		
		textComp.setText("Hold.");

		yield return new WaitForSeconds(4);

		textComp.setText("Breathe out.");

		yield return new WaitForSeconds(4);

		textComp.setText(" ");
		
	}

	public void startBreathing(){

		V_Layer layerZero = layerZeroObj.GetComponent<V_Layer>();
		V_Layer layerOne = layerOneObj.GetComponent<V_Layer>();
		V_Layer layerTwo = layerTwoObj.GetComponent<V_Layer>();
		V_Layer layerThree = layerThreeObj.GetComponent<V_Layer>();
		V_Layer layerFour = layerFourObj.GetComponent<V_Layer>();

		layerZero.animate(state);
		layerOne.animate(state);
		layerTwo.animate(state);
		layerThree.animate(state);
		layerFour.animate(state);

		switch (state){
			case 0:
			//breathIn
			//iTween.ScaleTo(this.gameObject, iTween.Hash("x", 0.003f, "y", 0.003f , "easetype","easeInOutExpo","time",intervalTime));
			state++;
			break;
			case 1:
			//breathInHold
			state++;
			break;
			case 2:
			//breathOut
			//iTween.ScaleTo(this.gameObject, iTween.Hash("x", 0.002f, "y",0.002f , "easetype","easeInOutExpo","time",intervalTime));
			state++;
			break;
			case 3:
			//breathOutHold
			state = 0;
			break;

		}
		
	}

	
}

