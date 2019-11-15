using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

	[SerializeField] private float speed;
	private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if(transform.position.z <= -2) {
			//destroy
			Destroy(gameObject);
		}
    }

	private void FixedUpdate() {
		rb.AddForce(new Vector3(0, 0, -speed*Time.fixedDeltaTime), ForceMode.VelocityChange);
	}
}
