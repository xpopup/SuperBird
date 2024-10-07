using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject wallPrefab;
    public float spawnTerm = 4;
    float spawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnTerm)
        {
            spawnTimer -= spawnTerm;
            GameObject obj = Instantiate(wallPrefab);
            obj.transform.position = new Vector2(10, Random.Range(-2.75f, 2.75f));
        }
    }
}
