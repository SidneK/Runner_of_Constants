using UnityEngine;

public class DestroyObject : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "PI")
		{
			Destroy(collision.gameObject);
			Logic.Instance.IsGameOver = true;
			Logic.Instance.RecordScore(Logic.Instance.Score > Logic.Instance.Record); // if predicate true, then record score(record)
			Logic.Instance.PrintScoreAndGameOver.text = "Game Over\nTap to reset\nScore: " +
								Logic.Instance.Score + "\nRecord: " + Logic.Instance.Record;
		}
	}
}
