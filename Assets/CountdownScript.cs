using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownScript : MonoBehaviour
{
    // カウントダウンする秒数
    public int countdownTime;
    //画面に表示するカウントダウン数
    public int displayCountdownTime;
    // Text UI への参照
    public Text countdownDisplay;
    public UnitychanBehavior uniBehav;
    public JudgementTextScript judgementTextScript;

    
    public void startCountDown(){
        // カウントダウンを開始
        StartCoroutine(Countdown());
        countdownDisplay.text = "あっちむいて\n3";
    }


    // カウントダウンを行うコルーチン
    IEnumerator Countdown()
    {
        // 残り時間が0になるまでループ
        while (countdownTime > 0)
        {
            // Textコンポーネントに残り時間を表示
            // カウントダウン終了後の処理
            if (displayCountdownTime == 0){
                countdownDisplay.text = "ほい!";
            }else{
                countdownDisplay.text = "あっちむいて\n" + displayCountdownTime.ToString();
            }
            // 1秒待機
            yield return new WaitForSeconds(1);
            // カウントを1減らす
            countdownTime--;
            displayCountdownTime--;
        }

        // カウントダウン終了後の処理
        countdownDisplay.text = "ほい!";
        
        //少し待機してから動かす
        yield return new WaitForSeconds(0.2f);
        //unityちゃんを動かす
        uniBehav.turn();
        judgementTextScript.displayJudgement();
    }
}
