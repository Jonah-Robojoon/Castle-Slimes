using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    public GameObject EnemyPrefab;


    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.E)){
            SpawnEnemy();
        }
    }
    private void SpawnEnemy()
    {
        Instantiate(EnemyPrefab,gameObject.transform.position,Quaternion.identity);
    }
}
