using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Pattern : MonoBehaviour {

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
		//V_Text textComp = textObj.GetComponent<V_Text>();
		//textComp.setText("Calmo helps to synchronize breathing by displaying an easy to follow pattern.");
		
	}

	IEnumerator waiter()
	{
		V_Text textComp = textObj.GetComponent<V_Text>();
		AudioSource sound = GetComponent<AudioSource>();
		//Rotate 90 deg
		textComp.setText("Hello welcome to Calmo.");
	
		yield return new WaitForSeconds(5);

		textComp.setText("Calmo helps to synchronize breathing by displaying an easy to follow pattern.");

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

	void test() {
		// V_Text textComp = textObj.GetComponent<V_Text>();
		//  Wait (5, () => {
        //      textComp.setText("Hello welcome to Calmo.");
        //  });
		// Wait (10, () => {
        //      textComp.setText("Calmo helps to synchronize breathing by displaying an easy to follow pattern.");
        // });
		// Wait (20, () => {
        //      textComp.setText("When the pattern expands breathe in and hold until it goes down.");
        // });
		// Wait (30, () => {
        //      textComp.setText("Breathe In now.");
        // });
		// Wait (40, () => {
        //      textComp.setText("Hold.");
        // });
        // yield WaitForSeconds(5);
		// textComp.setText();
		// yield WaitForSeconds(10);
		// textComp.setText();
		// yield WaitForSeconds(10);
		// textComp.setText("Breathe In now.");
		// yield WaitForSeconds(4);
		// textComp.setText("Hold.");
		// yield WaitForSeconds(4);
		// textComp.setText("And then breathe out.");
		// yield WaitForSeconds(4);
		// textComp.setText("Keep it out.");
		// yield WaitForSeconds(4);
		// textComp.setText("Breathe in.");
    }

	public void startBreathing(){
		V_Layer layerOne = layerOneObj.GetComponent<V_Layer>();
		V_Layer layerTwo = layerTwoObj.GetComponent<V_Layer>();
		V_Layer layerThree = layerThreeObj.GetComponent<V_Layer>();
		V_Layer layerFour = layerFourObj.GetComponent<V_Layer>();
		switch (state){
			case 0:
			//breathIn
			iTween.ScaleTo(this.gameObject, iTween.Hash("x", 0.003f, "y", 0.003f , "easetype","easeInOutExpo","time",intervalTime));
			layerOne.animate(2.12f,intervalTime -0.1f);
			layerTwo.animate(2.2f,intervalTime - 0.2f);
			layerThree.animate(3f,intervalTime - 0.1f);
			layerFour.animate(4f,intervalTime - 0.6f);

			state++;
			break;
			case 1:
			//breathInHold

			state++;
			break;
			case 2:
			//breathOut
			iTween.ScaleTo(this.gameObject, iTween.Hash("x", 0.002f, "y",0.002f , "easetype","easeInOutExpo","time",intervalTime));
			layerOne.animate(1f,intervalTime);
			layerTwo.animate(1f,intervalTime);
			layerThree.animate(1f,intervalTime);
			layerFour.animate(1f,intervalTime - 0.4f);
			

			state++;
			break;
			case 3:
			//breathOutHold

			state = 0;
			break;

		}
		
	}

	
}

