using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public class CollisionSwordPlayer : MonoBehaviour
    {
        [SerializeField]EnemyGhostMove ghostEnemy;
        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.tag == "Enemy")
            {


                
              //  ghostEnemy.Die();
              
                Destroy(collision.gameObject);
            }
        }
    }
}
