using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sayac : MonoBehaviour
{
	public float An;
	public Text sure;
    // Start is called before the first frame update
    void Start()
    {
		sure = GetComponent<Text>();
		
    }

    // Update is called once per frame
    void Update()
    {
		if(An >= 0)
		{
			An -= Time.deltaTime;
			sure.text = ((int)An).ToString();
		}
		else
		{
			SceneManager.LoadScene(6);
		}
    }
}
