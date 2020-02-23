using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sayfalarAras : MonoBehaviour
{
	
    // Start is called before the first frame update
    public void gecis(int id)
	{
		SceneManager.LoadScene(id);
	}

	
}
