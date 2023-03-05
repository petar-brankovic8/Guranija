using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField]
    public Text pointsText;
    [SerializeField]
    public Text pointsText2;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        Debug.Log("IDEGAS");
        pointsText.text = score + " POINTS";
        pointsText2.gameObject.SetActive(false);
    }
}
