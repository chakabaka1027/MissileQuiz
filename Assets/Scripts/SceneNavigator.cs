﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour {

    public void LoadNextScene(string sceneName){
        SceneManager.LoadScene(sceneName);
        if(sceneName == "AR Model"){
            FindObjectOfType<LrsCommunicator>().viewType = LrsCommunicator.ViewType.AR;
        } else if(sceneName == "3D Model"){
            FindObjectOfType<LrsCommunicator>().viewType = LrsCommunicator.ViewType.nonAR;
        } else {
            FindObjectOfType<LrsCommunicator>().viewType = LrsCommunicator.ViewType.other;
        }
    }

    public void CloseApp(){
        Application.Quit();
    }
}
