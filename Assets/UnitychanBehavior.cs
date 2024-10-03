using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanBehavior : MonoBehaviour
{

    public Animator ani;
    public int unitychanDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0,-2,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0,2,0);
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position += transform.forward * 0.05f;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.position += -transform.forward * 0.05f;
        }

        //キーを押して話す間に一回しか実行されないようにする(updateはすごい速さで繰り返されているからただのGetKeyだと2かいジャンプしてしまう)
        if(Input.GetKeyDown(KeyCode.Space)){
            ani.SetTrigger("jump");
        }
        
    }

    public void turn(){
        //transform.rotation = Quaternion.Euler(0, 90, 0);
        unitychanDirection = Random.Range(0,2);
        if(unitychanDirection == 0){
            for(int i=0; i<=90; ++i){
                transform.rotation = Quaternion.Euler(0, 90, 0);
                //transform.Rotate(Vector3.up, 1.0f);
                //transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            }
        }
        if(unitychanDirection == 1){
            for(int i=0; i<=90; ++i){
                transform.rotation = Quaternion.Euler(0, -90, 0);
                //transform.Rotate(Vector3.up, -1.0f);
                //transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
            }
        }
    }
}
