using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class basıldıMı : MonoBehaviour
{
	public float count=0;
	public Button btn;
	public Text countYaz;
	public Scrollbar race;

	
	public void bas()
	{

		count++;
		PlayerPrefs.SetFloat("count", count);
		
		countYaz.text = count.ToString();
		race.value = count / 5;

		if (count==5)
		{

			SceneManager.LoadScene(4);
		}
	}
}
