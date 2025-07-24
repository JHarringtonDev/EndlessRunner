using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    [SerializeField] bool isCollectible;
    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, moveSpeed) * Time.deltaTime;

        if (transform.position.z <= -5)
        {
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
