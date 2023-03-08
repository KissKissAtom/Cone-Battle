using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer1 : MonoBehaviour {

	//public static int nbImb;
	public float myTimer = 60.0f;
	public static bool finTimer = false;
	public Text TimerTexte;
	//bool ligne = false;
	public GameObject EndText;

	void Update(){
		if(myTimer>0){
			myTimer -= Time.deltaTime;
			TimerTexte.text = (int)myTimer + "S";
		}
		if(myTimer <=0){
			finTimer = true;
			TimerTexte.text = "Terminé";
			//EndText.SetActive(true);
			FindObjectOfType<Score50>().DestructionObjet();
		}
	}

	void OnTriggerEnter(Collider col)
	{
		


	}
}