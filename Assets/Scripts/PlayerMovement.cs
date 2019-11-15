using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
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
		
    }

	private void FixedUpdate() {
		if (Input.GetKey(KeyCode.A)) {
			rb.AddForce(new Vector3(-speed * Time.fixedDeltaTime, 0, 0), ForceMode.VelocityChange);
		}

		if (Input.GetKey("d")) {
			rb.AddForce(new Vector3(speed * Time.fixedDeltaTime, 0, 0), ForceMode.VelocityChange);
		}
	}

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag("Obstacle")) {
			//GAME OVER
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

}
