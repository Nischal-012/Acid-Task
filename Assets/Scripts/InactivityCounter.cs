using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InactivityCounter : MonoBehaviour
{
	private enum Activity
	{
		Idle,
		Active
	}
	#region Fields

	private Activity _activity;

	public float inactiveLimit;
	private float inactiveCounter;

	public UnityEvent onLimitCounter;
	public UnityEvent onStartCounter;

	[SerializeField]
	private Screensaver<ScreensaverData> screensaver;

	[SerializeField]
	private MainMenu<List<SectionData>> mainMenu;

	#endregion

	#region Methods

	private void Start()
	{
		PlayerPrefs.GetFloat("inActiveCounter", inactiveCounter);
	}

	private void Update()
	{
		inactiveCounter += Time.deltaTime;

		if (Input.GetMouseButtonDown(0))
		{
			inactiveCounter = 0;
		}

		if(inactiveCounter >= inactiveLimit)
		{
			OnLimitCounter();
		}

	}

	private void OnLimitCounter()
	{
		//some functionality here
	}

	private void OnApplicationQuit()
	{
		PlayerPrefs.SetFloat("inActiveCounter", inactiveCounter);
	}

	private void SaveData()
	{

	}

	private void LoadData()
	{

	}

	#endregion
}
