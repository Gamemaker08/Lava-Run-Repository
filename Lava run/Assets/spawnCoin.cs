using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCoin : MonoBehaviour
{
    public GameObject coinPrefab;
    float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 0.01f)
        {
            timer = 0;
            GameObject newCoins = Instantiate(coinPrefab);
            newCoins.transform.position = transform.position + Random.insideUnitSphere;
        }
    }
}
