using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isLeft = false;
    HealthDisplay healthDisplay;

    [SerializeField] int playerHealth;
    [SerializeField] int positionX;

    private void Awake()
    {
        healthDisplay = FindFirstObjectByType<HealthDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Time.timeScale != 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                if(isLeft)
                {
                    transform.position = new Vector3(positionX,transform.position.y ,transform.position.z);
                    isLeft = false;
                }
                else if (!isLeft)
                {
                    transform.position = new Vector3(-positionX,transform.position.y, transform.position.z);
                    isLeft = true;
                }
            }
        }
    }

    public void TakeDamage()
    {

        if(playerHealth >= 1)
        {
            playerHealth--;
            healthDisplay.DisplayCurrentHealth(playerHealth);
        }

        if (playerHealth <= 0)
        {
            Debug.Log("End game show stats");
            Time.timeScale = 0;
        }

    }
}
