using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(AudioSource))]
public class PickupItem : MonoBehaviour, IPickup
{
    public AudioClip pickupSound;
    public AudioClip dropSound;

    private Transform oldParent;
    private Rigidbody rb;
    private AudioSource source;

    void Start()
    {
        oldParent = transform.parent;
        rb = GetComponent<Rigidbody>();
        source = GetComponent<AudioSource>();
    }

    public void Pickup(Transform newParent)
    {
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        transform.SetParent(newParent);

        transform.localPosition = Vector3.zero;
        transform.localEulerAngles = Vector3.zero;
        source.PlayOneShot(pickupSound);
    }

    public void Drop(float throwPower)
    {
        transform.SetParent(oldParent);
        rb.isKinematic = false;
        rb.AddForce(transform.forward * throwPower, ForceMode.VelocityChange);
        source.PlayOneShot(dropSound);
    }
}
