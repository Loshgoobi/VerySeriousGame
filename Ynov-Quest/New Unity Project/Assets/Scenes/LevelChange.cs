using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour {


    string scene1 = "etage1";
    string scene2 = "etage2";
    public string scenes;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
           
            if (scenes == scene1)
            {
                Debug.Log("IIIINNN");
                SceneManager.LoadScene(scene1);
            }
            else if (scenes == scene2)
            {
                SceneManager.LoadScene(scene2);
            }
        }
    }
   
}
