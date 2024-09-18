using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{

    //get enemy prefab
    [SerializeField] private GameObject enemy;
    //get about of enemies
    [SerializeField] private int enemyAmt;
    //set a delay for the spawn
    [SerializeField] private float delay;
    //set position of enemies
    [SerializeField] private Vector3 enemyPos;


    void Start()
    {
        StartCoroutine(Spawn(delay));
    }

    //spawn enemies
    IEnumerator Spawn(float delay)
    {
        yield return new WaitForSeconds(delay);
        for(int i = 0; i < enemyAmt; i++)
        {
            Instantiate(enemy, enemyPos, enemy.transform.rotation);
        }
    }
}
