using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    private InfoPlayer _infoPlayer;
    float hp;

    private void Start()
    {
        _infoPlayer = GetComponent<InfoPlayer>();
    }
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        hp= _infoPlayer.GetCurrentHP();
  
        if (collision.gameObject.tag == "Enemy")
        {
            _infoPlayer.ChangeColorPlayerToRed();
            if (hp >= 0)
            {
                hp -= 10;

                 if (hp <= 0)
                {
                    Destroy(gameObject);
                }
                _infoPlayer.SetCurrentHP(hp);

            }   
        
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _infoPlayer.ChangeColorPlayerToWhite();
    }





}
