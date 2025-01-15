using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float leftSideX;
    public float rightSideX;
    public float timeToSpawn;
    
    private float _timer;

    private void Update()
    {
        if (_timer <= 0)
        {
            _timer = timeToSpawn + Random.Range(-0.5f, 0.5f);

            GameObject enemy = Instantiate(enemyPrefab);

            int rand = Random.Range(0, 2);
            Vector3 randPos = transform.position;
            if (rand == 0) randPos.x = leftSideX;
            else randPos.x = rightSideX;

            enemy.transform.position = randPos;
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }
}

