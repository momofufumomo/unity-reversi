using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject godObject;

    // Start is called before the first frame update
    void Start()
    {
        var god = godObject.GetComponent<reverseManager>();
        god.checkStoneObject();
    }

    // Update is called once per frame
    void Update()
    {
        StonePut();
    }

    // 石を置く
    private void StonePut()
    {
        // 0:左, 1:右, 2:中ボタン
        if (true)
        {
            // マウスポジション取得
            var vector3 = Input.mousePosition;
            // カメラからマウスの位置にRayを飛ばすためカメラの位置を取得
            var mousePosition = Camera.main.ScreenPointToRay(vector3);
            // レーザービームを投げて当たり判定を取る
            // レイのオリジン
            // mousePosition.direction:レイの向き。初期値が1となる。
            // 原点から向き（ベクトル）長さをかける
            RaycastHit rayHit;
            // Physics.Raycastの戻り値はtrueFalseしか帰ってこないのでoutで参照渡しをする
            // 何かにあたったときの情報はrayHitに入る

            // レイヤーを使いたかったらRaycastの引数に入れる
            // レイヤーは奥のものを貫通してみたいときに使うといい
            // レイヤーは見ないものをrayerMaskを使用して判定する
            
            if(Physics.Raycast(mousePosition, out rayHit))
            {
                // あたったときの処理
                // どこの床なのか取得して処理を書いていく
                var hitGameObject = rayHit.transform.gameObject; // 何かにあたったゲームオブジェクト
                if (hitGameObject.tag != "Stone") return;

                // 神のオブジェクトをしる
            }
            
            // Debug.DrawRay(mousePosition.origin, mousePosition.direction * 100, Color.red);
        }
    }
}
