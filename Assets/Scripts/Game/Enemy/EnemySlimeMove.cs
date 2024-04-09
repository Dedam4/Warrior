using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemySlimeMove : MonoBehaviour, MoveObject
    {
        public float _speed;
      


        [SerializeField] Transform[] rangeMove;
        private int spot = 0;
  
        void Update()
        {
            Move();
        }

        public void Move()
        {
          
            transform.position = Vector3.MoveTowards(transform.position, rangeMove[spot].position, _speed * Time.deltaTime);

            if(Vector2.Distance(transform.position, rangeMove[spot].position) <= 1f)
            {
               
                if(spot == 1)
                {
                    spot = 0;
                    RotateEnemyY(transform.position, 0);
                }
                else
                {
                    spot = 1;
                    RotateEnemyY(transform.position, 180);
                }
                
            }
           
        }

        

        private void RotateEnemyY(Vector2 _moveVector, int angle)
        {
            _moveVector = transform.eulerAngles;
            _moveVector.y = angle;
            transform.rotation = Quaternion.Euler(_moveVector);
        }

      
    }
}
