using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float leftRange = -6f; 
    private float rigthRange =7f;

    [SerializeField] private GameObject _slimeEnemyPrefab;
    [SerializeField] private GameObject _ghostEnemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSlime", 1.5f, 2);
        InvokeRepeating("SpawnGhost", 10f, 3.5f);
    }

   private void SpawnSlime()
    {
        Instantiate(_slimeEnemyPrefab,new Vector3(SetPosition(leftRange,rigthRange),0,0), Quaternion.identity);
    } 
    private void SpawnGhost()
    {
        Instantiate(_ghostEnemyPrefab, new Vector3(15,0,0), Quaternion.identity);
    }

    private float SetPosition(float leftRange, float rigthRange)
    {
        return Random.Range(leftRange, rigthRange);
    }
}
