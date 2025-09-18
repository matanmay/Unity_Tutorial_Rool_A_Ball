using UnityEngine;
using TMPro;

public class ScenceReferncer : TXRSingleton<ScenceReferncer>
{
    public TextMeshPro countText;
    public GameObject winTextObject;
    public int MAXPICKUPS = 10;
    public PickupSpawner pickupSpawner;
}
