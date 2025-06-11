using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI instructionText; 
    [SerializeField]
    private GameObject instructionObject;
    [SerializeField]
    private GameObject crossHair;

    private bool hasToggledInventory = false;
    
    void Start()
    {
        Debug.Log("name of " + SceneManager.GetActiveScene().name );
        if (SceneManager.GetActiveScene().name == "Helium Level"){
            instructionText.text = "Step 1: Make Helium\n(2) Protons\n (2) Electrons\n(2) Neutrons";
        }
        else if (SceneManager.GetActiveScene().name == "Beryllium Level"){
            instructionText.text = "Make Berylium\n(4)Protons\n (4) Electrons\n(5) Neutrons";
        }
    }
    void Update()
    {
        
    }
}
