using UnityEngine;
using UnityEngine.Events;

public class UIManager : MonoSingletone<UIManager>
{
    private Transform _canvasTrasn; 

    private void Awake()
    {
        _canvasTrasn = transform;
    }

    public void CreateStartUI()
    {
        // ModeUI �������� ���ҽ��� �ε��ؼ�, Instantiate�Ѵ�. 
        GameObject resGO = Resources.Load<GameObject>("Prefab/StartUI");
        GameObject sceanGO = Instantiate(resGO, _canvasTrasn, false);
    }

    public void CreateModeUI()
    {
        // ���ӸŴ����� ModUI������ְ� �־��µ� 
        GameObject resGO = Resources.Load<GameObject>("Prefab/ModeUI");       

        GameObject sceanGO = Instantiate(resGO, _canvasTrasn, false);
        ModeUI uiComp = sceanGO.GetComponent<ModeUI>();


        // ���⼭ ��ư �̺�Ʈ ���� ���!
        uiComp.AddTimeClickEvent(() => SceneManager.Instance.LoadGameSceneTimeAttack());
        uiComp.AddStageClickEvent(() => SceneManager.Instance.LoadGameSceneStageMode());

        //���� ��ȯ�ǰ� modeUI�� ������� �ʴ´�.... 

    }

    public void CreateScoreUI()
    {
        GameObject scoreUIRes = Resources.Load<GameObject>("Prefab/ScoreUI");
        GameObject scoreUIGo = Instantiate(scoreUIRes, _canvasTrasn, false);
        ScoreUI scoreUIComp = scoreUIGo.GetComponent<ScoreUI>();
    }


}
