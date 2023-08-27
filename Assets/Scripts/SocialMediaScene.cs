using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class SocialMediaScene : MonoBehaviour
{
    [SerializeField] GameObject Panel_share;
	[SerializeField] Text txtPanelScore;
    [SerializeField] Text txtHomeScore;

	public void ShareScore ()
	{
		txtPanelScore.text = "20"; //get the same score in home sceen

		//open the score panel
		Panel_share.SetActive (true);//show the panel
		StartCoroutine ("TakeScreenShotAndShare");
	}

	IEnumerator TakeScreenShotAndShare ()
	{
		yield return new WaitForEndOfFrame ();

		Texture2D tx = new Texture2D (Screen.width, Screen.height, TextureFormat.RGB24, false);
		tx.ReadPixels (new Rect (0, 0, Screen.width, Screen.height), 0, 0);
		tx.Apply ();

		string path = Path.Combine (Application.temporaryCachePath, "sharedImage.png"); //image name
		File.WriteAllBytes (path, tx.EncodeToPNG ());

		Destroy (tx); //to avoid memory leaks

		new NativeShare ()
			.AddFile (path)
			.SetSubject ("This is my score")
			.SetText ("share your score with your friends")
			.Share ();


		Panel_share.SetActive (false); //hide the panel
	}
}

