using UnityEngine;
using TMPro;

public class GameManager : TXRSingleton<GameManager>
{
    private TextMeshPro countText;
    private GameObject winTextObject;
    private int count;

    void Start()
    {
        count = 0;
        countText = ScenceReferncer.Instance.countText;
        winTextObject = ScenceReferncer.Instance.winTextObject;
        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= ScenceReferncer.Instance.MAXPICKUPS)
        {
            winTextObject.SetActive(true);
        }
    }

    public void AddPoints(int points)
    {
        count += points;
        SetCountText();
    }
}
