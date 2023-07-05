
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Screensaver<ScreensaverData>
{
	private CanvasGroup canvasGroup;
	private Image imagePrefab;
	private VideoPlayer videoPlayerPrefab;
	private Image previousImage;
	private VideoRaw previousVideo;
	private Coroutine switchRoutine;


	private IEnumerator SwitchContent()
	{
		yield return null;
	}
}
