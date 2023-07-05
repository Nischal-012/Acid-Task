using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class UIPanel : MonoBehaviour
{
	#region Fields

	protected RectTransform rectTransform;

	protected bool show;
	public  bool Show
	{
		get
		{
			return show;
		}
		set
		{
			if (show != value)
			{
				show = value;
				if (show)
				{
					onShow?.Invoke();
				}
				else
				{
					onNotShow?.Invoke();
				}
			}
		}
	}

	private UnityEvent onShow;
	private UnityEvent onNotShow;

	#endregion

	#region Methods

	protected virtual void Start()
	{
		if(rectTransform == null)
		{
			rectTransform = GetComponent<RectTransform>();
		}
	}

	#endregion
}
