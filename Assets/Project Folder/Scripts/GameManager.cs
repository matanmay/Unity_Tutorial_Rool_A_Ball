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
        countText = SceneReferencer.Instance.countText;
        winTextObject = SceneReferencer.Instance.winTextObject;
        SetCountText();
        winTextObject.SetActive(false);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= SceneReferencer.Instance.MAXPICKUPS)
        {
            winTextObject.SetActive(true);
            countText.gameObject.SetActive(false);
        }
    }

    public void AddPoints(int points)
    {
        count += points;
        SetCountText();
    }
}
