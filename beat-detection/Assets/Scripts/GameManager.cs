using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : AudioSyncer
{
    public TextMeshProUGUI ScoreText;
    private int scoreCounter;
    public void OnClickMethod()
    {
       // base.OnBeat();

        if (m_isBeat == true)
        {
            Debug.Log("On beat!!!");
            scoreCounter = scoreCounter + 307;
            ScoreText.text = scoreCounter.ToString();

        }
        else if (m_isBeat == false)
        {
            Debug.Log("Not on beat????");
            scoreCounter = scoreCounter - 103;
            ScoreText.text = scoreCounter.ToString();
        }
    }
}
