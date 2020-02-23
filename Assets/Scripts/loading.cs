using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loading : MonoBehaviour
{

	public Button button;
	public AudioSource audio;

	
	public void sesAc()
	{
		audio.volume = 0.1f;

	}
	public void sesKapa()
	{
		audio.volume = 0;
	}

	

}