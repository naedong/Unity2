using UnityEngine;

public class Scrooll : MonoBehaviour {
    public float speed = 10f; // 이동 속도

     private void Update() {
        // 게임 오브젝트를 왼쪽으로 일정 속도로 평행 이동하는 처리
        if( !GameManager.instance.isGameover){
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    void Start(){
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
    }


}