using UnityEngine;

public class PickUpController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Toucher"))
        {
            Destroy(gameObject);
            GameManager.Instance.AddPoints(1);
        }
    }
}
