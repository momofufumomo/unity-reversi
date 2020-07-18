using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reverseManager : MonoBehaviour
{
    // grobal変数を置く
    [SerializeField]
    private GameObject stone;
    public int boardSize = 8;
    private GameObject[,] createStones;
    private enum StoneState
    {
        None,
        White,
        Black
    }
    private StoneState[,] state;


    // Start is called before the first frame update
    // コンストラクタみたいなやつ
    void Start()
    {
        createStones = new GameObject[8, 8];
        state = new StoneState[8, 8];
        // stoneの生成を行う i:縦, j:横
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                createStones[i,j] = Instantiate(stone, new Vector3(i, 0.6f, j), Quaternion.identity);
                state[i, j] = StoneState.None;
            }
        }
        state[3, 4] = StoneState.Black;
        state[4, 3] = StoneState.Black;
        state[3, 3] = StoneState.White;
        state[4, 4] = StoneState.White;
        createStones[3, 4].SetActive(true);
        createStones[4, 3].SetActive(true);
        createStones[3, 3].SetActive(true);
        createStones[4, 4].SetActive(true);
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                changeColor(state[i, j], i, j);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private method
    private void changeColor(StoneState state, int x, int z)
    {
        switch (state)
        {
            case StoneState.Black:
                createStones[x, z].transform.Rotate(180, 0, 0);
                break;
            case StoneState.White:
                createStones[x, z].transform.Rotate(0, 0, 0);
                createStones[x, z].SetActive(true);
                break;
            default:
                break;
        }
    }
}
