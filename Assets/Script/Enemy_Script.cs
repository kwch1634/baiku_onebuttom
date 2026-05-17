using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _CloneEnemyScaleY = 0f;
    private int lastGeneratedEnemyX = -1;
    private float _CloneDestroyTime = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player._Xpos > 0)
        {
            _CloneDestroyTime += Time.deltaTime;

            int enemeyXPos = (int)Player._Xpos;
            if (enemeyXPos % 20 == 0 && enemeyXPos % 100 != 0 && enemeyXPos != lastGeneratedEnemyX)
            {
                _CloneDestroyTime = 0f; //五秒立つ前にリセットしてるから後で修正

                if (_CloneDestroyTime > 5f)
                {
                    GameObject[] existingEnemies = GameObject.FindGameObjectsWithTag("Enemy");
                    foreach (GameObject enemy in existingEnemies)
                    {
                        Destroy(enemy);
                        Debug.Log("敵削除: " + enemy.transform.position.x);
                    }
                }

                lastGeneratedEnemyX = enemeyXPos;

                _CloneEnemyScaleY = Random.Range(0.5f, 1.5f);
                GameObject _enemyClone = Instantiate(_enemyPrefab, new Vector3(enemeyXPos + 50, 1, -7), Quaternion.identity);
                _enemyClone.transform.localScale = new Vector3(1, _CloneEnemyScaleY, 1);
                Debug.Log("敵生成: " + (enemeyXPos + 50) + " スケールY: " + _CloneEnemyScaleY);
            }
        }
    }
}
