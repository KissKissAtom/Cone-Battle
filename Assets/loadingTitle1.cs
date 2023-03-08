using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingTitle1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(Loading());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Loading()
   {
   	yield return new WaitForSeconds(3);

   	SceneManager.LoadScene("Intro");
   
   }

}
