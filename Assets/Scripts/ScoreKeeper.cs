using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int gameScore;
    [SerializeField] TextMeshProUGUI scoreDisplay;

    BulletSpawner spawner;

    private void Awake()
    {
        spawner = FindFirstObjectByType<BulletSpawner>();
    }

    public void AddScore()
    {
        gameScore++;
        spawner.increaseSpeed();
        scoreDisplay.text = "Score: " + gameScore;
    }
}
