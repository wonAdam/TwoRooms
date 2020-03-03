using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Memo_Mgr : MonoBehaviour
{
    [Header("Dot Prefabs")]
    public GameObject blackdot;
    public GameObject bluedot;
    public GameObject reddot;
    
    [Header("Memo Paraer Prefab")]
    public GameObject memoPaper_prefab; // Asset에 있는 memoPaper 프리팹을 넣을 변수

    [Header("Memo Open N Close Manage")]
    public GameObject memo;
    public GameObject memoOpenBtn;
    public GameObject memoPaperSpawning; // memoPaper가 생성될 부모 빈오브젝트

    [Header("Pen Btns")]
    [SerializeField] private GameObject BlackPenBtn;
    [SerializeField] private GameObject BluePenBtn;
    [SerializeField] private GameObject RedPenBtn;
    [SerializeField] private GameObject EraseBtn;
    [SerializeField] private GameObject CloseBtn;


    [HideInInspector]
    public GameObject selectedDotColor;
    [HideInInspector]
    public GameObject memoPaper = null; // 현재 생성된 memoPaper를 넣는 변수
    private Vector2 mousePosition;
    private Vector2 touchPosition;
    private Touch touch;

    
#region Custom Methods
    //메모장을 열고 여는 버튼은 숨깁니다.
    public void OpenMemoFunc()
    {
        memo.SetActive(true);
        memoOpenBtn.SetActive(false);
        if(!memoPaper){
            memoPaper = Instantiate(memoPaper_prefab, memoPaperSpawning.transform, false);
        }
    }

    public void CloseMemoFunc()
    {
        memo.SetActive(false);
        memoOpenBtn.SetActive(true);
    }

    public void EraseClicked()
    {
        Destroy(memoPaper.gameObject);
        memoPaper = Instantiate(memoPaper_prefab, memoPaperSpawning.transform, false);
    }

#endregion

#region Unity Methods
    void Start()
    {
        selectedDotColor = null;
    }

    void Update()
    {
        if(memo.activeInHierarchy == true){
            if (BlackPenBtn.GetComponent<Button>().IsInteractable() == false)
            {
                selectedDotColor = blackdot;
            }
            else if (BluePenBtn.GetComponent<Button>().IsInteractable() == false)
            {
                selectedDotColor = bluedot;
            }
            else if (RedPenBtn.GetComponent<Button>().IsInteractable() == false)
            {
                selectedDotColor = reddot;
            }
            else
            {
                selectedDotColor = null;
            }
        }
        
    }

    #endregion

    

}
