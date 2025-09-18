using UnityEngine;

public class PickUpController : MonoBehaviour
{
    // string name,Vector3 pickupPosition, float spawnTime, float pickupTime
    private string pickupName;
    private Vector3 pickupPosition;
    private float spawnTime;
    private float pickupTime;

    void Start()
    {
        pickupName = this.gameObject.name;
        pickupPosition = this.transform.position;
        spawnTime = Time.time;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Toucher"))
        {
            pickupTime = Time.time;
            TXRDataManager.Instance.ReportPickupEvent(pickupName, pickupPosition, spawnTime, pickupTime);
            SceneReferencer.Instance.pickupSpawner.RemovePickup(this.gameObject);
        }
    }
}
