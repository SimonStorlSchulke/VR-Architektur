using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class tele : MonoBehaviour {

    [SerializeField]private string index;

    private void OnTriggerEnter(Collider other)
    {
           
            SceneManager.LoadScene(index);
        
    }







}
