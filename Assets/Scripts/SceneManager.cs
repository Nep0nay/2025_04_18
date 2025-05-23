using System;
using System.Collections;
using Mono.Cecil;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoSingletone<SceneManager>
{
    private void Awake()
    {
        
    }

    public void LoadGameSceneTimeAttack()
    {
        StartCoroutine(LoadSceneAsync("GameScene"));
    }
    public void LoadGameSceneStageMode()
    {
        
    }

    public static IEnumerator LoadSceneAsync(string sceneName)
    {
        // 여기서 게임씬이 다 로드 된 이후에 다음 코드를 읽겠습니다. 
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);

        // 플레이어 생성해주면 됨 
        GameObject resGO = Resources.Load<GameObject>("Prefab/PangPlayer");
        GameObject realGO = Instantiate(resGO);
        realGO.transform.position = new Vector3(0, -2.66f, 0);

        // 배경도 로드해야겠다.
        GameObject bottomRes = Resources.Load<GameObject>("Prefab/Bottom");
        GameObject bottomGo = Instantiate(bottomRes);

        // 일반 공을 생성해봐야겠다. 
        GameObject gongRes = Resources.Load<GameObject>("Prefab/Gong");
        GameObject gongGo = Instantiate(gongRes);
        gongGo.transform.position = new Vector3(0, 6, 0);

        Transform tr = realGO.transform;


    }
}
