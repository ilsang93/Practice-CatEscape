using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawnerManager : MonoBehaviour
{
    [SerializeField] private GameObject arrowPrefab;
    [SerializeField] private GameObject leftRangeVec, RightRangeVec;
    [SerializeField] private float spawnDelay;

    private float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<UIController>().isGameOver) return;
        spawnTime += Time.deltaTime;

        if (spawnTime <= spawnDelay) return;

        Instantiate(arrowPrefab).transform.position = new Vector3(Random.Range(leftRangeVec.transform.position.x, RightRangeVec.transform.position.x), 4f, 0f);
        spawnTime = 0;
    }
}
