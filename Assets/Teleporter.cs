using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    private bool hasElement = false;
    private string targetElement = ""; 

    void Start(){
        hasElement = false;
        if(SceneManager.GetActiveScene().name == "Helium level"){
            targetElement = "Helium"; 
        }
        if(SceneManager.GetActiveScene().name == "Beryllium Level"){
            Debug.Log("Inside level if");
            targetElement = "Beryllium"; 
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag(targetElement)){
            hasElement = true;

        }
        if (collision.gameObject.CompareTag("Player") && hasElement == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
