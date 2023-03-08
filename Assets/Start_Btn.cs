using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Start_Btn : MonoBehaviour
{

  public  bool GameIsPause = true;
  //private int index;
    // Start is called before the first frame update
  
  //public InputField CharacterName;
 // public int numeroPersonnage;
 // public GameObject selector;

  void Start(){
  
      
  }

  public void StartButton(){
      //PlayerPrefs.SetInt("PersonnageSelectionne",numeroPersonnage);
      SceneManager.LoadScene("AccueilPage");
      Time.timeScale = 1f;
    GameIsPause = false;
      //GameObject.Find("Charater").GetComponent<CollisionMesh>().nbrFlower = 0;
    }

     public void HomeButton(){
      //PlayerPrefs.SetInt("PersonnageSelectionne",numeroPersonnage);
      SceneManager.LoadScene("Menu");
      Time.timeScale = 1f;
      GameIsPause = false;
     // GameObject.Find("PlotsTir").GetComponent<Score50>().nbrFlower = 0;
    }

     public void NextLevel1(){
      //PlayerPrefs.SetInt("PersonnageSelectionne",numeroPersonnage);
     SceneManager.LoadScene("Level1");
     Time.timeScale = 1f;
    GameIsPause = false;
     // GameObject.Find("Charater").GetComponent<CollisionMesh>().nbrFlower = 0;*/
    } 

    public void NextLevel2(){
    	SceneManager.LoadScene("Level2");
      Time.timeScale = 1f;
    GameIsPause = false;
    }

    public void NextLevel3(){
    	SceneManager.LoadScene("Level3");
    }

    public void NextLevel4(){
    	SceneManager.LoadScene("Level4");
    }





   /* public void QuitButton(){
       Application.Quit();
    }*/



    }

