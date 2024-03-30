using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace Assets.Scripts
{
    public class EnemyGhostMove : MonoBehaviour, MoveObject
    {
         float frequency = 5f;

         float magnitude = 1.5f;
         float moveSpeed = 5f;
        Vector3 position;
       [SerializeField] Animator animator;

        [SerializeField] GameObject enemyDieAnim; 

        void Start()
        {
            position = transform.position;
        }

      
        void Update()
        {
            Move();
        }
        public void Move()
        {
            position += (-1)*transform.right * Time.deltaTime * moveSpeed;
            transform.position = position + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
        }

        public void Die()
        {
           // Instantiate(enemyDieAnim, gameObject.transform.position, Quaternion.identity);
           // gameObject.SetActive(false);
        
           
        

        }

        
    }
}
