using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WorkbenchScript : MonoBehaviour{
    [SerializeField] private GameObject protonPrefab;
    [SerializeField] private GameObject electronPrefab;
    [SerializeField] private GameObject neutronPrefab;
    [SerializeField] private Transform spawnPoint; 

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Rock")) {
            Destroy(collision.gameObject);
            Instantiate(neutronPrefab, spawnPoint.position, Quaternion.identity);
        }
        if (collision.gameObject.CompareTag("Apple")) {
            Destroy(collision.gameObject);
            Instantiate(protonPrefab, spawnPoint.position, Quaternion.identity);
        }
        if (collision.gameObject.CompareTag("Duck")) {
            Destroy(collision.gameObject);
            Instantiate(electronPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
