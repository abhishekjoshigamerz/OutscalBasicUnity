using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MySecondScript : MonoBehaviour
{
    public Button button;
   
    public string newScene;
     public Button masterbutton;
    private string masterscene="MasterScene";
    private void Start(){
        button.onClick.AddListener(OnButtonClick);
        masterbutton.onClick.AddListener(OnMasterClick);
    }
    private void OnButtonClick(){
        Debug.Log("Button Clicked!");
        SceneManager.LoadScene(newScene);
    }
    private void OnMasterClick(){
        SceneManager.LoadScene(masterscene);
    }
   
}
