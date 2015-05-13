using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonyScript : MonoBehaviour 
{
	public Text text;

	void Start ()
	{
		text.text = getText("res_to_check") + "\n\n" + getText("res_to_replace");
	}

	string getText(string name)
	{
		string rName = string.Format("{0}.R$string", Application.bundleIdentifier);
		Debug.Log(rName);
		
		int id = new AndroidJavaClass(rName).GetStatic<int>(name);
		
		Debug.Log(id);
		
		AndroidJavaObject oAct = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
		
		return oAct.Call<string>("getText", id);
	}
}
