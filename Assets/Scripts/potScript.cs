
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potScript : MonoBehaviour
{
    public See Content_Script;
    [SerializeField]
    private GameObject Hydrogen;
    [SerializeField]
    private GameObject Lithium;  
    [SerializeField]
    private GameObject Beryllium; 
    [SerializeField]
    private GameObject Helium; 
    [SerializeField]
    public Transform spawnPoint; 
    [SerializeField]
    public List<int> electronIDs = new List<int>(); 
    [SerializeField]
    public List<int> protonIDs = new List<int>(); 
    [SerializeField]
    public List<int> neutronIDs = new List<int>(); 
    private bool hasSpawnedHelium = false; 
    private bool hasSpawnedHydrogen = false; 
    private bool hasSpawnedLithium = false; 
    private bool hasSpawnedBeryllium = false; 
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("electron")) {
            if ( !electronIDs.Contains(collision.gameObject.GetInstanceID())    ) {
                electronIDs.Add(collision.gameObject.GetInstanceID());
                Content_Script.electronsAmount += 1;
                collision.gameObject.GetComponent<Renderer>().enabled = false;
                collision.gameObject.GetComponent<Collider>().enabled = false;
                Destroy(collision.gameObject, 2f);
            }
        }
        if (collision.gameObject.CompareTag("proton")) {
            if ( !protonIDs.Contains(collision.gameObject.GetInstanceID())) {
                protonIDs.Add(collision.gameObject.GetInstanceID());
                Content_Script.protonsAmount += 1;
                collision.gameObject.GetComponent<Renderer>().enabled = false;
                collision.gameObject.GetComponent<Collider>().enabled = false;
                Destroy(collision.gameObject, 2f);

            }
            
        }
        if (collision.gameObject.CompareTag("neutron")) {
            if (!neutronIDs.Contains(collision.gameObject.GetInstanceID())) {
                neutronIDs.Add(collision.gameObject.GetInstanceID());
                Content_Script.neutronsAmount += 1;
                collision.gameObject.GetComponent<Renderer>().enabled = false;
                collision.gameObject.GetComponent<Collider>().enabled = false;
                Destroy(collision.gameObject, 2f);
            }
        }
    }
    void Update(){
       // if ( (electronIDs.Count == 1 && protonIDs.Count == 1 && neutronIDs.Count == 0) && hasSpawnedHydrogen == false ){
           // spawnHydrogen(); 
            //hasSpawnedHydrogen = true; 
        //}
        //else if ( (electronIDs.Count == 2 && protonIDs.Count == 2 && neutronIDs.Count == 2) && hasSpawnedHelium == false ){
         //   spawnHelium(); 
        //    hasSpawnedHelium = true; 
        //}
        //else if ( (electronIDs.Count == 3 && protonIDs.Count == 3 && neutronIDs.Count == 4) && hasSpawnedLithium == false ){
         //   spawnLithium(); 
         //   hasSpawnedLithium = true; 
        //}
        if ( (electronIDs.Count == 4 && protonIDs.Count == 4 && neutronIDs.Count == 5) && hasSpawnedBeryllium == false ){
            spawnBeryllium(); 
            hasSpawnedBeryllium = true; 

        }
    } 
    private void spawnHelium(){
        Debug.Log("spawn Helium");
        Vector3 spawnPosition = spawnPoint.position;
        Instantiate(Helium, spawnPoint.position, Quaternion.identity);
    }
    private void spawnHydrogen(){
        Debug.Log("spawn Hydrogen");
        Vector3 spawnPosition = spawnPoint.position;
        Instantiate(Hydrogen, spawnPoint.position, Quaternion.identity);
    }
    private void spawnLithium(){
        Debug.Log("spawn Lithium");
        Vector3 spawnPosition = spawnPoint.position;
        Instantiate(Lithium, spawnPoint.position, Quaternion.identity);
    }
    private void spawnBeryllium(){
        Debug.Log("spawn Beryllium");
        Vector3 spawnPosition = spawnPoint.position;
        Instantiate(Beryllium, spawnPoint.position, Quaternion.identity);
        reset();
    }
    private void reset(){
        electronIDs.Clear();
        protonIDs.Clear();
        neutronIDs.Clear();
        Content_Script.protonsAmount = 0;
        Content_Script.electronsAmount = 0;
        Content_Script.neutronsAmount = 0;
    }
    
}
