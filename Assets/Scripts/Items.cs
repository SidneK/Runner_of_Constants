using UnityEngine;

public class Items : MonoBehaviour
{
	public float Speed;

	private Transform tr;
	void Start()
	{
		InitializeItems();
	}

	void Update()
	{
		if (!Logic.Instance.IsGameOver && !Logic.Instance.IsPause)
		{
			Move();
		}
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Destroy")
		{
			Logic.Instance.Numbers.Remove(gameObject); // at first delete a element of the collection 
			Destroy(gameObject);					   // after, delete itself object
		}
	}

	private void InitializeItems()
	{
		tr = GetComponent<Transform>();
	}

	private void Move()
	{
		tr.position = new Vector3(tr.position.x - Speed, tr.position.y, tr.position.z);
	}
}
