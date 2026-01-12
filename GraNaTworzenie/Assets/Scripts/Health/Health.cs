using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float StartingHealth;
    internal float fillAmount;

    public float CurrentHealth { get; private set; }
    private Animator anim;
    private bool Dead;

    private void Awake()
    {
        CurrentHealth = StartingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth - _damage, 0, StartingHealth);
        
        if(CurrentHealth > 0)
        {
            anim.SetTrigger("Hurt");
        }
        else
        {
            if(!Dead)
            {
            anim.SetTrigger("Die");
            GetComponent<PlayerMovement>().enabled = false;
            Dead = true;

            }

        }
    }

    public void AddHealth(float _value)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + _value, 0, StartingHealth);
    }
}
