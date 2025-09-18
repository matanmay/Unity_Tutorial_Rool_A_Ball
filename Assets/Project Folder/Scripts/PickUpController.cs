using UnityEngine;

public class PickUpController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Toucher"))
        {
            SceneReferencer.Instance.pickupSpawner.RemovePickup(this.gameObject);
            
        }
    }
}
