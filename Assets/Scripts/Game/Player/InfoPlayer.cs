using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPlayer : MonoBehaviour
{

    private float maxHP = 100f;
    private float currentHP = 100f;

    private SpriteRenderer spriteRendererPlaey;


    private void Start()
    {
        spriteRendererPlaey= GameObject.Find("Skin").GetComponent<SpriteRenderer>();
    }



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

    public void ChangeColorPlayerToRed()
    {
        spriteRendererPlaey.color = Color.red;
    }
    public void ChangeColorPlayerToWhite()
    {
        spriteRendererPlaey.color = Color.white;
    }
    
}
