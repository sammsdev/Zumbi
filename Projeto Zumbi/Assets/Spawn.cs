using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject template;
    public Terrain terrain;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnEnemy", 0f, 4f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void SpawnEnemy()
    {
        //Debug.Log("Spawned enemy");
        GameObject obj = Instantiate(template);
        Vector3 terrainSize = terrain.GetComponent<Terrain>().terrainData.size;
        Vector3 position = new Vector3 (Random.Range( 1 , terrainSize.x - 1), 1 , Random.Range( 1, terrainSize.z -1));
        obj.transform.position = position;
    }
}
