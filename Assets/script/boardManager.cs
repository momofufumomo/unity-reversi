using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardManager : MonoBehaviour
{
    // grobal変数を置く
    [SerializeField]
    private GameObject cube;
    private int boardSize = 8;

    // Start is called before the first frame update
    // コンストラクタみたいなやつ
    void Start()
    {
        // boardの生成を行う
        for(int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                Instantiate(cube, new Vector3(i, 0.0f, j), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    // １フレームごとに実行される（オブジェクトが生きている限り）
    // 動きを止めたかったらオブジェクトを抹消する
    void Update()
    {
        
    }
}
