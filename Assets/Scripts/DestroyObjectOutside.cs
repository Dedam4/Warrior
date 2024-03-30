using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOutside : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision != null)
        {
            Debug.Log(1);
        }
    }
}
