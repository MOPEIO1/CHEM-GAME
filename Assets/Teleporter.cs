using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    private bool hasElement = false;
    private string targetElement = ""; 

    void Start(){
        if(SceneManager.GetActiveScene().name == "Helium level"){
            targetElement = "Helium"; 
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Berylium level");
        }
        
        if(collision.gameObject.CompareTag(targetElement)){
        }
    }
}
