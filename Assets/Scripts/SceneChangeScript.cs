using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChangeScript : MonoBehaviour
{

    //Using Event Triggers on Unity to switch between Scenes
    public void SceneLoading(int SceneNumber){
        SceneManager.LoadScene(SceneNumber);
    }
}
