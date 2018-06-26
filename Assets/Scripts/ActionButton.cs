using UnityEngine;

public class ActionButton : MonoBehaviour
{
	public void UseButton(string Name)
	{
		if (IsDigit(Name[0]) && !Logic.Instance.IsPause)
		{
			Logic.Instance.IsGameOver = false;
			char number = Name[0];
			if (number == Logic.PI[Logic.Instance.Score])
			{
				Logic.Instance.CreateSquare();
				++Logic.Instance.Score;
				Logic.Instance.PrintScoreAndGameOver.enabled = true;
				Logic.Instance.PrintScoreAndGameOver.text = "Score: " + Logic.Instance.Score;
			}
		}
		else if (Name == "Pause")
		{
			Time.timeScale = 0;
			Logic.Instance.IsPause = true;
			Logic.Instance.PausePopMenu.SetActive(true);
		}
		else if (Name == "Resume")
		{
			Time.timeScale = 1;
			Logic.Instance.IsPause = false;
			Logic.Instance.PausePopMenu.SetActive(false);
		}
		else if (Name == "Exit")
			Application.Quit();
	}

	private bool IsDigit(char Name)
	{
		bool flag = false;
		for (char i = '0'; i <= '9'; ++i)
			if (Name == i)
				flag = true;
		return flag;
	}
}
