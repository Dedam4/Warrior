using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assets.Scripts
{
    public class CollisionSwordPlayer : MonoBehaviour
    {
       
        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.tag == "Enemy")
            {

              
                Destroy(collision.transform.parent.gameObject);
            
            }
        }
    }
}
