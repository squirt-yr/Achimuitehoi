using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public UnitychanBehavior uniBehav;
    public CountdownScript countdownScript;
    public JudgementTextScript judgement;

    public void OnClick(){
        Debug.Log("押された!");
        countdownScript.startCountDown();
        //uniBehav.turn();

    }
}
