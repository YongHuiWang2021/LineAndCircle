using UnityEngine;
using System.Collections;
using XD.Scripts;

public class InitGame : MonoBehaviour {


	// Use this for initialization
	void Start () {
    
        StartCoroutine(StartGame());
	}
	IEnumerator StartGame()
	{
		yield return new WaitForSeconds(1.5f);
        Initiate.Fade("Game", SystemParam.Instance.GameColor, SystemParam.Instance.Damp);
    }
    
}
