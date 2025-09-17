using UnityEngine;
using TMPro;

public class ScenceReferncer : TXRSingleton<GameManager>
{
    public TextMeshPro countText;
    public GameObject winTextObject;
    public int MAXPICKUPS = 10;
    public PickupSpawner pickupSpawner;
}
