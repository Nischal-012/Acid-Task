using System.Collections.Generic;
[System.Serializable]
public class ScreensaverData : Data
{
	ContentData Content;
	public bool Active;
	public bool DisableTouch;
	public string Name;
	private List<string> ContentIDs;
}
