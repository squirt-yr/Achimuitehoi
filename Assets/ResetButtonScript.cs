using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButtonScript : MonoBehaviour
{

    public void ResetButton(){
        SceneManager.LoadScene("SampleScene");
    }
}
