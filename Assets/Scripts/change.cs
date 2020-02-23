using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class change : MonoBehaviour
{
	public Slider condition;
	public Slider speed;
	public Slider stamina;
	public Slider startSpeed;
	public Slider competing;
	public Text jockeyName;
	public Text horseName;
	public Text odd;
	public Text weight;
	public Text age;
	public Text gender;
	public Text win;
	public int count=0;
	public Text horseNumber;

	public void ChangeAbility()
	{
		
		count++;
		
		if (count == 1)
		{
			jockeyName.text = "Furkan";
			horseName.text = "Düldül";
			condition.value = 0.28F;
			speed.value = 0.53F;
			stamina.value = 0.61F;
			startSpeed.value = 0.53F;
			competing.value = 0.4F;
			odd.text = "30";
			weight.text = "120";
			age.text = "4";
			gender.text = "M";
			win.text = "20%";
			 horseNumber.text = count.ToString();
		}
		else if (count==2)
		{
			jockeyName.text = "Halis";
			horseName.text = "Boldpilot";
			condition.value = 0.2F;
			speed.value = 0.3F;
			stamina.value = 0.2F;
			startSpeed.value = 0.2F;
			competing.value = 0.1F;
			odd.text = "40";
			weight.text = "130";
			age.text = "5";
			gender.text = "M";
			win.text = "10%";
			horseNumber.text = count.ToString();

		}
		else if (count==3)
		{
			jockeyName.text = "Vehbi";
			horseName.text = "Aslan";
			condition.value = 0.5F;
			speed.value = 0.4F;
			stamina.value = 0.3F;
			startSpeed.value = 0.3F;
			competing.value = 0.2F;
			odd.text = "50";
			weight.text = "110";
			age.text = "3";
			gender.text = "F";
			win.text = "35%";
			horseNumber.text = count.ToString();
		}
		else if (count == 4)
		{
			jockeyName.text = "Halit";
			horseName.text = "Fernando";
			condition.value = 0.6F;
			speed.value = 0.3F;
			stamina.value = 0.1F;
			startSpeed.value = 0.4F;
			competing.value = 0.2F;
			odd.text = "25";
			weight.text = "130";
			age.text = "3";
			gender.text = "M";
			win.text = "40%";
			horseNumber.text = count.ToString();
		}
		else if (count >=5)
		{
			count = 1;
			jockeyName.text = "Furkan";
			horseName.text = "Düldül";
			condition.value = 0.28F;
			speed.value = 0.53F;
			stamina.value = 0.61F;
			startSpeed.value = 0.53F;
			competing.value = 0.4F;
			odd.text = "30";
			weight.text = "120";
			age.text = "4";
			gender.text = "M";
			win.text = "20%";
			horseNumber.text = count.ToString();
		}

	}
	

	
}
