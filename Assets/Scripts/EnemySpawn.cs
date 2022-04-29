using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    float EnemySpawnDelay = 0.2f;
    public Transform MinValue = null;
    public Transform MaxValue = null;
    float randval;

    public GameObject Enemy;
    public GameObject RedEnemy;
    public GameObject BlueEnemy;

    void Start()
    {
        StartCoroutine(EnemyCreate());
    }

    public IEnumerator EnemyCreate()
    {
        while (true)
        {
            randval = Random.Range(1f, 3f);
            if (randval >= 2)
            {
                Instantiate(Enemy, new Vector2(Random.Range(MinValue.position.x, MaxValue.position.x), MaxValue.position.y), Quaternion.identity);
                yield return new WaitForSeconds(EnemySpawnDelay);
                randval = 0;
                Instantiate(RedEnemy, new Vector2(Random.Range(MinValue.position.x, MaxValue.position.x), MaxValue.position.y), Quaternion.identity);
                yield return new WaitForSeconds(EnemySpawnDelay);
                randval = 0;
                Instantiate(BlueEnemy, new Vector2(Random.Range(MinValue.position.x, MaxValue.position.x), MaxValue.position.y), Quaternion.identity);
                yield return new WaitForSeconds(EnemySpawnDelay);
                randval = 0;
            }
            
        }
    }
}

