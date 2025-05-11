using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WorkbenchScript : MonoBehaviour{
    [SerializeField] private GameObject protonPrefab;
    [SerializeField] private GameObject electronPrefab;
    [SerializeField] private Transform spawnPoint; 

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Rock")) {
            Destroy(collision.gameObject);
            // Instantiate(electronPrefab, spawnPoint.position, Quaternion.identity);
            int number = Random.Range(1, 4); // 0 to 99 inclusive
            for(int i=0; i < number; i++){
                int chance = Random.Range(0, 2); 
                if (chance == 0){
                    Instantiate(protonPrefab, spawnPoint.position, Quaternion.identity);
                } else{
                    Instantiate(electronPrefab, spawnPoint.position, Quaternion.identity);
                }
            }
        } 
    }
}
