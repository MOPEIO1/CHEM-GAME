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
    IEnumerator spawnExplosion(float duration)
    {
        Debug.Log("Before");
        yield return new WaitForSeconds(duration);
    }


}

