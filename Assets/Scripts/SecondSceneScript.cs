using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class SecondSceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button buttonnext;
    public Button buttonprev;

    public string nextScene;
    public string previousScene;
     public Button masterbutton;
    private string masterscene="MasterScene";
    void Start()
    {
        buttonnext.onClick.AddListener(NextScene);
        buttonprev.onClick.AddListener(PreviousScene);
        masterbutton.onClick.AddListener(OnMasterClick);
    }

    void NextScene(){
        SceneManager.LoadScene(nextScene);
    }
    void PreviousScene(){
         SceneManager.LoadScene(previousScene);
    }

     private void OnMasterClick(){
        SceneManager.LoadScene(masterscene);
    }
}
