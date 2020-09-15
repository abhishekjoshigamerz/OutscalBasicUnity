using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FourthScript : MonoBehaviour
{
    
    public Button button;
    public string newScene;
     public Button masterbutton;
    private string masterscene="MasterScene";
    void Start()
    {
        button.onClick.AddListener(ChangeScene);
        masterbutton.onClick.AddListener(OnMasterClick);
    }

    // Update is called once per frame
    void   ChangeScene(){
        SceneManager.LoadScene(newScene);
    }
     private void OnMasterClick(){
        SceneManager.LoadScene(masterscene);
    }
}
