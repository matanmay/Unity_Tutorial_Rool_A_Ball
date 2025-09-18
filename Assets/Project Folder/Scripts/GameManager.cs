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

    void update()
    {
        if (count >= SceneReferencer.Instance.MAXPICKUPS)
        {
            WinGame();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    public void AddPoints(int points)
    {
        count += points;
        SetCountText();
    }

    private void WinGame()
    {
        winTextObject.SetActive(true);
        countText.gameObject.SetActive(false);
    }
}
