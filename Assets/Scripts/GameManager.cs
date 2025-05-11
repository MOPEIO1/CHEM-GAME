using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI instructionText; 

    void Start()
    {
        Debug.Log("anme of " + SceneManager.GetActiveScene().name );
        if (SceneManager.GetActiveScene().name == "Helium level"){
            instructionText.text = "Step 1: get a rock\nStep 2: break rock\nStep 3: bring particles to pot and make helium";
        }
    }
    void Update()
    {
        
    }
}
