using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Weapon;
    public KeyCode _Input;

    private bool IsAttacking;
    void Start()
    {
        Weapon.SetActive(false);
    }

    IEnumerator waiter()
    {
        Attack();
        yield return new WaitForSeconds(1);
        FinishAttack();
    }

    void Update()
    {
        if (Input.GetKeyDown(_Input))
        {
            IsAttacking = true;
        }
    }

    private void FixedUpdate()
    {
        if (IsAttacking)
        {
            StartCoroutine(waiter());
            IsAttacking = false;
        }
    }

    private void Attack() {
        Weapon.SetActive(true);
    }

    private void FinishAttack()
    {
        Weapon.SetActive(false);
    }
}