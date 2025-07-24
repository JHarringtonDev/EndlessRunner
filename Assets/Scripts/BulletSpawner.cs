using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] bullets;
    [SerializeField] float fireDelay;
    int bulletSpeed = 15;
    bool gameIsOver;

    private void Start()
    {
        StartCoroutine(SpawnBullets());
    }

    IEnumerator SpawnBullets()
    {
        while (gameIsOver == false)
        {
            GameObject clone = Instantiate(bullets[Random.Range(0, bullets.Length)]);

            clone.GetComponent<BulletScript>().SetSpeed(bulletSpeed);

            bulletSpeed++;

            yield return new WaitForSeconds(fireDelay);
        }   
    }

}
