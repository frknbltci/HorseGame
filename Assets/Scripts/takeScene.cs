using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class takeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		PlayerPrefs.SetInt("Scene", SceneManager.GetActiveScene().buildIndex);
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
