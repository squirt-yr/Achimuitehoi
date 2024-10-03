using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JudgementTextScript : MonoBehaviour
{
    // Textコンポーネントへの参照
    public Text mousePositionText;
    // 前のフレームでのマウスのx座標
    private float previousMouseX;
    // Unity-chanオブジェクトのTransformをInspectorで割り当てる
    public Transform unityChanTransform;
    // Uitychanの向きを取得したい
    public UnitychanBehavior unibehav;
    //マウスの方向
    public int mouseDirection;

    // Start is called before the first frame update
    public void Start()
    {
        // ゲームが開始した時点でのマウスのx座標を取得
        previousMouseX = Input.mousePosition.x;
        mouseDirection = 10;
    }

    // Update is called once per frame
    void Update()
    {
        // 現在のマウスのスクリーン座標を取得
        Vector3 mousePosition = Input.mousePosition;
        // マウスのスクリーン座標をワールド座標に変換
        //Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // 1. Unity-chanのワールド座標を取得
        Vector3 unityChanPosition = unityChanTransform.position;
        // 2. カーソルのスクリーン座標をワールド座標に変換
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.nearClipPlane));
        // カーソルの位置をコンソールに表示
        //Debug.Log("Mouse World Position: " + mouseWorldPosition);
        // 3. Unity-chanのx座標とマウスのx座標を比較して、左右を判定
        if (mouseWorldPosition.x > unityChanPosition.x){
            Debug.Log("Mouse is on the right side of Unity-chan");
            //mousePositionText.text = "右";
            mouseDirection = 0;
        }
        else if (mouseWorldPosition.x < unityChanPosition.x){
            Debug.Log("Mouse is on the left side of Unity-chan");
            //mousePositionText.text = "左";
            mouseDirection = 1;
        }

        // if(mouseDirection == unibehav.unitychanDirection){
        //     mousePositionText.text = "勝ち";
        // }else {
        //     mousePositionText.text = "負け";
        // }

    }

    public void displayJudgement(){
        if(mouseDirection == unibehav.unitychanDirection){
            mousePositionText.text = "勝ち";
        }else {
            mousePositionText.text = "負け";
        }
    }

    
}
