using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class MainMenu<T> where T : List<SectionData>
{
	[Serializable]
	public class MainMenuButtons<SectionData>
	{
		private Button buttonPrefab;
		private Image background;
		private TextMeshProUGUI name;
	}

	private ScrollRect scroll;
	private VideoPlayer background;

}
