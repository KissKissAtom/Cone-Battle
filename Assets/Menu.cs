using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
	public static bool GameIsPause = false;
	public GameObject PauseMenuUi;

    // Start is called before the first frame update

  /* public void Update(){



  	
  		if(GameIsPause)
  		{
  			Pause();
  			
  		}
  	/*	else{
  			Pause();
  			
  		}*/
  	
   


//}

	public void Resume(){
		PauseMenuUi.SetActive(false);
		Time.timeScale = 1f;
		GameIsPause = false;
	}

	public void Pause(){
		PauseMenuUi.SetActive(true);
		Time.timeScale = 0f;
		GameIsPause = true;
	}


/*public void ButtonResume(){
	PauseMenuUi.SetActive(false);
		Time.timeScale = 1f;
		GameIsPause = false;
	
}*/


public void ButtonRestart()
    {
        SceneManager.LoadScene("Intro");
        Time.timeScale = 1f;
        GameIsPause = false;

    }

   public void ButtonQuit()
    {
         Application.Quit();
    }

}
