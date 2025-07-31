using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int gameScore;

    public void AddScore()
    {
        gameScore++;
    }
}
