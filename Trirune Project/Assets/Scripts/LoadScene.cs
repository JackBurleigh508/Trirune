﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public string SceneToLoad;

	public void loadScene()
	{
		SceneManager.LoadScene (SceneToLoad);
	}
}
