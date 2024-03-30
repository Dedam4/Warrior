using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPlayer : MonoBehaviour
{

    private float maxHP = 100f;
    private float currentHP = 100f;



    public float GetMaxHP()
    {
        return maxHP;
    }
    public float GetCurrentHP()
    {
        return currentHP;
    }
    public void SetCurrentHP(float hp)
    {
        currentHP = hp;
    }
    
}
