using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private ScoreUI ui;

    private uint _score = 0u;
    private uint _maxScore = 0u;

    private void Start()
    {
        if (PlayerPrefs.HasKey("MaxScore"))
        {
            _maxScore = (uint)PlayerPrefs.GetInt("MaxScore");
        }
    }

    public void AddValue(uint value = 1)
    {
        _score += value;
        ui.ActualizeScore(_score);
    }
    public uint GetScore()
    {
        return _score;
    }
    public uint GetMaxScore()
    {
        return _maxScore;
    }
}
