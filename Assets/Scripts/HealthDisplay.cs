using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] Image[] hearts;
    public void DisplayCurrentHealth(int currentHealth)
    {
        hearts[currentHealth].gameObject.SetActive(false);
    }
}
