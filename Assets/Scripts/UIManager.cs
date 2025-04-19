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
        // ModeUI 프리팹을 리소스를 로드해서, Instantiate한다. 
        GameObject resGO = Resources.Load<GameObject>("Prefab/StartUI");
        GameObject sceanGO = Instantiate(resGO, _canvasTrasn, false);
    }

    public void CreateModeUI()
    {
        // 게임매니저가 ModUI만들어주고 있었는데 
        GameObject resGO = Resources.Load<GameObject>("Prefab/ModeUI");       

        GameObject sceanGO = Instantiate(resGO, _canvasTrasn, false);
        ModeUI uiComp = sceanGO.GetComponent<ModeUI>();


        // 여기서 버튼 이벤트 직접 등록!
        uiComp.AddTimeClickEvent(() => SceneManager.Instance.LoadGameSceneTimeAttack());
        uiComp.AddStageClickEvent(() => SceneManager.Instance.LoadGameSceneStageMode());

        //씬이 전환되고 modeUI가 사라지지 않는다.... 

    }

    public void CreateScoreUI()
    {
        GameObject scoreUIRes = Resources.Load<GameObject>("Prefab/ScoreUI");
        GameObject scoreUIGo = Instantiate(scoreUIRes, _canvasTrasn, false);
        ScoreUI scoreUIComp = scoreUIGo.GetComponent<ScoreUI>();
    }


}
