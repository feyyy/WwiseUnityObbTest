using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;

public class TestUIManager : MonoBehaviour {
	
	public void LoadBank(string name) {
		AkBankManager.LoadBank(name, false, false);
	}
	public void UnloadBank(string name) {
		AkBankManager.UnloadBank(name);
	}
	public void PlayEvent(string name) {
		AkSoundEngine.PostEvent(name, gameObject);
	}
}
