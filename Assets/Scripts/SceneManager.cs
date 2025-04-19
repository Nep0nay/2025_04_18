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
        // ���⼭ ���Ӿ��� �� �ε� �� ���Ŀ� ���� �ڵ带 �аڽ��ϴ�. 
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);

        // �÷��̾� �������ָ� �� 
        GameObject resGO = Resources.Load<GameObject>("Prefab/PangPlayer");
        GameObject realGO = Instantiate(resGO);
        realGO.transform.position = new Vector3(0, -2.66f, 0);

        // ��浵 �ε��ؾ߰ڴ�.
        GameObject bottomRes = Resources.Load<GameObject>("Prefab/Bottom");
        GameObject bottomGo = Instantiate(bottomRes);

        // �Ϲ� ���� �����غ��߰ڴ�. 
        GameObject gongRes = Resources.Load<GameObject>("Prefab/Gong");
        GameObject gongGo = Instantiate(gongRes);
        gongGo.transform.position = new Vector3(0, 6, 0);

        Transform tr = realGO.transform;


    }
}
