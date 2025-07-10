using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, moveSpeed) * Time.deltaTime;
    }
    public void increaseSpeed()
    {
        if (moveSpeed < 50)
        {
          moveSpeed++;
        }
    }
}
