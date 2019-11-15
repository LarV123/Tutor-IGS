using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

	[SerializeField] private GameObject obstacle;

	[SerializeField] private float timeToSpawn;
	private float spawnCooldown = 0;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
		if (spawnCooldown <= 0) {
			Spawn();
			spawnCooldown = timeToSpawn;
		} else {
			spawnCooldown -= Time.deltaTime;
		}
    }

	private void Spawn() {
		Instantiate(obstacle, new Vector3(Random.Range(-4f, 4f) ,-0.5f, 30), Quaternion.identity);
	}

	private void FixedUpdate() {
		
	}
}
