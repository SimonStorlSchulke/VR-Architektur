using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tele : MonoBehaviour {

    [SerializeField]private string index;
    void Awake() { }




    void Update()
    {
          
            SceneManager.LoadScene(index);
        
    }







}
