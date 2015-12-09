using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	Animator _animator;

	void Start()
	{
		_animator = GetComponent<Animator>();

		SetWalking(false);
	}
	
	void Update()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			SetWalking(true);

			transform.Translate(new Vector3(3 * Time.deltaTime, 0, 0));
		}
		else
		{
			SetWalking(false);
		}
	}

	private void SetWalking(bool walking)
	{

		_animator.SetBool("Walking", walking);
	}
}
