using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isLeft = false;
    
    [SerializeField] int positionX;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
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
}
