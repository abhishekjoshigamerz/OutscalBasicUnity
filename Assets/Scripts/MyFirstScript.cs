using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    void Awake() {
        
    }
    
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("This is Debugging!"); 
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.F)){
          Debug.Log("F has been pressed down");
      }
      if(Input.GetKey(KeyCode.F)){
          Debug.Log("F has been pressed ");
      }
      if(Input.GetKeyUp(KeyCode.F)){
           Debug.Log("F has been released ");
      }
      if(Input.GetMouseButtonDown(0)){
           Debug.Log("LMB has been pressed ");
      }
      
    }
    void LateUpdate() {
        
    }

    private void OnDestroy() {
        
    }
}
