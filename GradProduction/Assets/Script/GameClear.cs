using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClear : MonoBehaviour
{
    //EnemyCount
    GameObject EnemySpawn;
    EnemySpawn EnemyCount;

    //カウント用
    public GameObject Shocky, Shitappa, ChoD;
    int ShoCount, ShiCount, ChoCount;
    // Start is called before the first frame update
    void Start()
    {
        EnemySpawn = GameObject.Find("EnemySpawn1");
        EnemyCount = EnemySpawn.GetComponent<EnemySpawn>();

        ShoCount = 99;
        ShiCount = 99;
        ChoCount = 99;
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyCount.SpawnMaxflg == true)
        {
            ShoCount = GameObject.FindGameObjectsWithTag("Shocky").Length;
            ShiCount = GameObject.FindGameObjectsWithTag("Shitappa").Length;
            ChoCount = GameObject.FindGameObjectsWithTag("ChoD").Length;

            if(ShoCount == 0 && ShiCount == 0 && ChoCount == 0)
            {
                SceneManager.LoadScene("End");
            }
        }
    }
}
