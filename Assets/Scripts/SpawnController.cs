using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject spawnPrefab;
    public float rateSpawn;
    private float currentTime;
    private float x;

    public Transform minX;
    public Transform maxX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= rateSpawn)
        {
            currentTime = 0;

            x = Random.Range(minX.position.x, maxX.position.x);

            GameObject tempPrefab = Instantiate(spawnPrefab) as GameObject;
            tempPrefab.transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
    }
}
