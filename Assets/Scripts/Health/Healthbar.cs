using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    [SerializeField] private Health playerHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        totalHealthBar.fillAmount = playerHealth.currentHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        currentHealthBar.fillAmount = playerHealth.currentHealth;
    }
}
