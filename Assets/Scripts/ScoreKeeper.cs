using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] int gameScore;

    BulletSpawner spawner;

    private void Awake()
    {
        spawner = FindFirstObjectByType<BulletSpawner>();
    }

    public void AddScore()
    {
        gameScore++;
        spawner.increaseSpeed();
    }
}
