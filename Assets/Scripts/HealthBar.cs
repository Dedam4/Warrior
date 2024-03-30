using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image _healthBar;
    public InfoPlayer _player;

   
    void Start()
    {
        _healthBar = GetComponent<Image>();
        _player = FindObjectOfType<InfoPlayer>();
        
    }

   
    void Update()
    {
        _healthBar.fillAmount = _player.GetCurrentHP() / _player.GetMaxHP();
    }
}
