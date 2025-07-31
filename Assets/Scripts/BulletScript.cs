using UnityEngine;

public class BulletScript : MonoBehaviour
{
    ScoreKeeper scoreKeeper;

    [SerializeField] int moveSpeed;
    [SerializeField] bool isCollectible;
    // Update is called once per frame

    private void Awake()
    {
        scoreKeeper = FindFirstObjectByType<ScoreKeeper>();
    }

    void Update()
    {
        transform.position -= new Vector3(0, 0, moveSpeed) * Time.deltaTime;

        if (transform.position.z <= -5)
        {
            if(!isCollectible)
            {
                scoreKeeper.AddScore();
            }

            Destroy(gameObject);
        }
    }
    public void SetSpeed(int bulletSpeed)
    {
       moveSpeed = bulletSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null)
        {
            PlayerController player = other.gameObject.GetComponent<PlayerController>();
            
            if(isCollectible)
            {
                Debug.Log("collectible");
                scoreKeeper.AddScore();
            }
            else
            {
                player.TakeDamage();
            }

            EndCollision();
        }
        else
        {
            Debug.Log("script not found");
        }
    }

    void EndCollision()
    {
        Destroy(gameObject);
    }
}
