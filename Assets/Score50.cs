using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Score50 : MonoBehaviour
{
    public GameObject Rejouer;
    public Text score;
    public Text scoreInGame;
    public  static int nbrFlower;
    public GameObject PtsText;   
    public bool GameIsPause = false;
    public Text pointsRecord;
    public bool colliderDetect = false;
    public int ptsNumber = 1;
    public Color blueColor;
    public Color whiteColor;
    public GameObject Plane1;
    public GameObject Plane2;
    public GameObject Plane3;

    void Start(){
        InvokeRepeating("Pts",0,0.1f);
    }


   
    void Awake(){
        pointsRecord.text = PlayerPrefs.GetInt("PointsRecord",0).ToString();
       
    }

    public void DestructionObjet()
    {
      Rejouer.SetActive(true);

     Time.timeScale = 0f;
        GameIsPause = true;
        if(nbrFlower > PlayerPrefs.GetInt("PointsRecord",0)){
         PlayerPrefs.SetInt("PointsRecord",nbrFlower);
        PlayerPrefs.Save();
        }
    }
     
    
   
    void OnTriggerEnter(Collider col)
    {

         
        /*if(col.gameObject.tag == "pts_100")
        {
        //DestructionObjet();
        //nbrFlower = 0;
        	nbrFlower +=100;
        score.text = nbrFlower.ToString() + " Points";
        scoreInGame.text = nbrFlower.ToString() + " Points";
         
    }
    else if(col.gameObject.tag == "pts_50")
    {
    	nbrFlower +=50;
        score.text = nbrFlower.ToString() + " Points";
        scoreInGame.text = nbrFlower.ToString() + " Points";

        
    }*/

    if(col.gameObject.tag == "pts_50")
    {
    	ptsNumber = 50;
        Plane1.transform.GetComponent<Renderer>().material.color = blueColor;
        
        colliderDetect = true;
    }

        
    

    else if(col.gameObject.tag == "pts_150")
    {

        ptsNumber = 100;

         Plane2.transform.GetComponent<Renderer>().material.color = blueColor;
      
        colliderDetect = true;

        }

    else if(col.gameObject.tag == "pts_200")
    {

        ptsNumber = 200;

         Plane3.transform.GetComponent<Renderer>().material.color = blueColor;
      
        colliderDetect = true;

        }
    
    else if(col.gameObject.tag == "plot_cible")
    {

        ptsNumber = 1000;
      
        colliderDetect = true;

        }
    

    }

    void OnTriggerExit(Collider col){

    	if(col.gameObject.tag == "pts_50")
    {
    	
        Plane1.transform.GetComponent<Renderer>().material.color = whiteColor;
        
       
    }

        
    

    else if(col.gameObject.tag == "pts_150")
    {

     

         Plane2.transform.GetComponent<Renderer>().material.color = whiteColor;
      
        

        }

    else if(col.gameObject.tag == "pts_200")
    {

       

         Plane3.transform.GetComponent<Renderer>().material.color = whiteColor;
      

        }
    
    
    }

    
    public void Pts()
    {
        if(colliderDetect == true){
        nbrFlower += ptsNumber;
        Plane1.transform.GetComponent<Renderer>().material.color = whiteColor;
        score.text = nbrFlower.ToString() + " Points";
        scoreInGame.text = nbrFlower.ToString() + " Points";
        colliderDetect = false;
            }
      

    }

   
}
