﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene_Change : MonoBehaviour
{
    public string Scene;

    public void Load()
    {
        SceneManager.LoadScene(Scene);
    }

  
}
