using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] bullets;
    [SerializeField] float fireDelay;
    bool gameIsOver;

    private void Start()
    {
        StartCoroutine(SpawnBullets());
    }

    IEnumerator SpawnBullets()
    {
        while (gameIsOver == false)
        {
            Instantiate(bullets[Random.Range(0, 2)]);

            yield return new WaitForSeconds(fireDelay);
        }   
    }

}
