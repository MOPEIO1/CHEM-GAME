using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompoundMaker : MonoBehaviour
{
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
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("electron")) {
            if ( !electronIDs.Contains(collision.gameObject.GetInstanceID())    ) {
                electronIDs.Add(collision.gameObject.GetInstanceID());
                collision.gameObject.transform.localScale = new Vector3(10f, 10f, 10f);
            }
        }
        if (collision.gameObject.CompareTag("proton")) {
            if ( !protonIDs.Contains(collision.gameObject.GetInstanceID())) {
                protonIDs.Add(collision.gameObject.GetInstanceID());
                collision.gameObject.transform.localScale = new Vector3(10f, 10f, 10f);

            }
            
        }
        if (collision.gameObject.CompareTag("neutron")) {
            if (!neutronIDs.Contains(collision.gameObject.GetInstanceID())) {
                neutronIDs.Add(collision.gameObject.GetInstanceID());
                collision.gameObject.transform.localScale = new Vector3(10f, 10f, 10f);
            }
        }
    }
    void Update(){
        if ( (electronIDs.Count == 1 && protonIDs.Count == 1 && neutronIDs.Count == 1) && hasSpawnedHelium == false ){
            spawnHelium(); 
            hasSpawnedHelium = true; 
        }
    } 
    private void spawnHelium(){
        Debug.Log("spawn helium");
        Vector3 spawnPosition = spawnPoint.position;
        Instantiate(Helium, spawnPoint.position, Quaternion.identity);
    }
}
