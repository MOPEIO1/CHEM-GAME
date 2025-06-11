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
            collision.gameObject.GetComponent<Renderer>().enabled = false;
            collision.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(collision.gameObject, 2f);
            Instantiate(neutronPrefab, spawnPoint.position, Quaternion.identity);
        }
        if (collision.gameObject.CompareTag("apple")) {
            collision.gameObject.GetComponent<Renderer>().enabled = false;
            collision.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(collision.gameObject, 2f);
            Instantiate(protonPrefab, spawnPoint.position, Quaternion.identity);
        }
        if (collision.gameObject.CompareTag("duck")) {
            collision.gameObject.GetComponent<Renderer>().enabled = false;
            collision.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(collision.gameObject, 2f);
            Instantiate(electronPrefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
