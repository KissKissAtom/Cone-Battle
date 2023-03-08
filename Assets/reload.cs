using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reload : MonoBehaviour
{

	//[SerializeField]
	public GameObject ball;
	float Time = 5;
    // Start is called before the first frame update
    void Start()
    {
    
        InvokeRepeating("Spawn",5,5);
    }

    // Update is called once per frame
    public void Spawn()
    {
        GameObject bullet = Instantiate (ball, new Vector3 (1.5f,0f,-4f), Quaternion.identity);
        bullet.GetComponent<SwipeControl1>().enabled = true;
        
        StartCoroutine(DestroyBall(bullet,Time));
    }

   private IEnumerator DestroyBall(GameObject bullet, float delay)
   {
   	yield return new WaitForSeconds(delay);
   	Destroy(bullet);
   }


}
