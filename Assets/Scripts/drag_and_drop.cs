using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag_and_drop : MonoBehaviour
{
    public GameObject Hydrogen;
    public AudioSource popSound;
    Vector3 mousePosition;
    public GameObject Explosion;
    private Vector3 GetMousePos(){
        return Camera.main.WorldToScreenPoint(transform.position);
    }


    private void OnMouseDown(){
        mousePosition = Input.mousePosition - GetMousePos();
    }


    private void OnMouseDrag(){
        transform.position  = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
    // private void OnCollisionEnter(Collision collision){
    //     if ( (this.tag == "proton" && collision.gameObject.CompareTag("electron") ) || (this.tag == "electron" && collision.gameObject.CompareTag("proton")) ){
    //         if (gameObject.GetInstanceID() < collision.gameObject.GetInstanceID()){
    //             Debug.Log("spawn hydrogen ");
    //             Vector3 spawnPosition = collision.contacts[0].point;
    //             Instantiate(Hydrogen, collision.contacts[0].point, Quaternion.identity);
    //             if (Explosion != null)
    //             {
    //                 var copy = Instantiate(Explosion, spawnPosition, Quaternion.identity);
    //                 popSound.Play();  
    //                 Destroy(copy, 1.0f);
    //                 // StartCoroutine(spawnExplosion(5.0f));
    //             }
    //             MeshRenderer mr = GetComponent<MeshRenderer>();
    //             mr.enabled = false;
    //             Destroy(gameObject, 5.0f );
    //             Destroy(collision.gameObject);
    //         }
    //     }
    // }
    IEnumerator spawnExplosion(float duration)
    {
        Debug.Log("Before");
        yield return new WaitForSeconds(duration);
    }


}

