using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class MasterSceneScript : MonoBehaviour
{
    public Button scene1button;
    public Button scene2button;
    public Button scene3button;
    
    public string scene1;
    public string scene2;
    public string scene3;
    
    void Start()
    {
        scene1button.onClick.AddListener(GotoScene1);
        scene2button.onClick.AddListener(GotoScene2);
        scene3button.onClick.AddListener(GotoScene3);
    }

    void GotoScene1(){
        SceneManager.LoadScene(scene1);
    }
    void GotoScene2(){
        SceneManager.LoadScene(scene2);
    }
    void GotoScene3(){
        SceneManager.LoadScene(scene3);
    }
}
