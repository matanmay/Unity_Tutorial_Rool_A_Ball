using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

// Stores references for everything needer to refer to in the scene.
public class SceneReferencer : TXRSingleton<SceneReferencer>
{
    public TextMeshPro countText;
    public GameObject winTextObject;
    public int MAXPICKUPS = 10;
    public PickupSpawner pickupSpawner;
}