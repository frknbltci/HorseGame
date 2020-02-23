using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputVer : MonoBehaviour
{
	public Text username;
	
	void Start()
    {
			username.text = PlayerPrefs.GetString("username");
		
	}

  
}
