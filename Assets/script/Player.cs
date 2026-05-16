using UnityEngine;
using UnityEngine.Rendering;

public class Player : MonoBehaviour
{
    public float power = 10f; // 1초당 감소할 수치
    private bool isAttacking = false; // 공격 중인지 체크하는 스위치
    public int money = 0;
    private float moneyCounter = 0f;


    public void Attack()
    {
        isAttacking = true;
        if (District.currentSelected != null)
        {

            float reduction = power * Time.deltaTime;
            moneyCounter += reduction;

            if ( moneyCounter > 1.0f)
            {
                int moneyAdd = Mathf.FloorToInt(moneyCounter);
                money += moneyAdd;
                moneyCounter -= moneyAdd;
            }

            District.currentSelected.ModifyStats(0, -reduction, 0);
            if (District.currentSelected.intel == 0)
            {
                isAttacking = false;
            }
        }
    }

    void Update()
    {
 
        
        if (isAttacking == true)
        {
            Attack();
            
        }
    }

    public void powerUp()
    {
        power += 1;
    }
    
}