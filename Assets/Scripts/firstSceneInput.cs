using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class firstSceneInput : MonoBehaviour
{

	public void ınputAl(InputField username)
	{
		PlayerPrefs.SetString("username", username.text);
		SceneManager.LoadScene(1);

	}

	public void devamEt()
	{
		var index = PlayerPrefs.GetInt("Scene");
		SceneManager.LoadScene(index);
	}


}
