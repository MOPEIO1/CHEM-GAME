using UnityEngine;

public interface IPickup
{
    void Pickup(Transform newParent);
    void Drop(float throwPower);
}
