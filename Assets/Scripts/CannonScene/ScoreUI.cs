using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private string _text;

    private void Start()
    {
        ActualizeScore(0);
    }

    public void ActualizeScore(uint score)
    {
        _scoreText.text = _text + " " + score.ToString();
    }
}
