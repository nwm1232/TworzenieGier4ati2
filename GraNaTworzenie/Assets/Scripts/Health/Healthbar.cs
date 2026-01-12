using UnityEngine;
using UnityEngine.UI;


public class Healthbar : MonoBehaviour
{
 [SerializeField] private Health PlayerHealth;
 [SerializeField] private Image TotalhealthBar;
 [SerializeField] private Image CurrenthealthBar;

    private void Start()
    {
        TotalhealthBar.fillAmount = PlayerHealth.CurrentHealth /10;
    }

     private void Update()
    {
        CurrenthealthBar.fillAmount = PlayerHealth.CurrentHealth / 10;

    }

}
