#pragma warning disable 0649
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CloseUp : MonoBehaviour
{
    [SerializeField] public GameObject[] Panel_to_CloseUp;
    [SerializeField] GameObject[] Panel_to_Touch;
    [SerializeField] GameObject[] Panel_to_Out;
    [SerializeField] public GameObject PreviousPanel;

    [SerializeField] const float BGM_Volume = 0.4f;

    void Update()
    {
        OnTouchDetected();
    }

    void OnEnable()
    {
        if(PreviousPanel != null)
            PreviousPanel.SetActive(false);

    }
    
    void OnDisable()
    {
        if(PreviousPanel != null)
            PreviousPanel.SetActive(true);

    }

    IEnumerator AudioFadeOutPause()
    {

        FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(0f, 2f);
        yield return new WaitForSeconds(2f);
        FindObjectOfType<GameManager>().GetComponent<AudioSource>().Pause();
    
    }


    private void OnTouchDetected()
    {

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {

                Debug.Log("Touch Detected");
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit))
                {
                    Debug.Log(hit.collider.gameObject.name + "Hit Success");
                    for(int i = 0 ; i < Panel_to_Touch.Length; i++){
                        if(hit.collider.gameObject == Panel_to_Touch[i]) 
                        {
                            Panel_to_CloseUp[i].SetActive(true);



                            //BGM
                            if(Panel_to_CloseUp[i].tag == "Hint")
                            {
                                if(gameObject.tag == "Hint") return;

                                Panel_to_CloseUp[i].GetComponent<CloseUp>().StartCoroutine(AudioFadeOutPause());

                            }
                            else
                            {

                                if(gameObject.tag == "Hint")
                                {
                                    FindObjectOfType<GameManager>().GetComponent<AudioSource>().UnPause();
                                    FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(BGM_Volume, 2f);
                                }

                                else
                                    return;

                            }



                            return;
                        }
                    }

                    for(int i = 0; i < Panel_to_Out.Length; i++)
                    {
                        if(hit.collider.gameObject == Panel_to_Out[i])
                        {
                            gameObject.SetActive(false);


                            if(PreviousPanel == null)
                            {
                                    FindObjectOfType<GameManager>().GetComponent<AudioSource>().UnPause();
                                    FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(BGM_Volume, 2f);
                            }

                            else
                            {
                                if(PreviousPanel.tag == "Hint")
                                    PreviousPanel.GetComponent<CloseUp>().StartCoroutine(AudioFadeOutPause());
                                else
                                {
                                    FindObjectOfType<GameManager>().GetComponent<AudioSource>().UnPause();
                                    FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(BGM_Volume, 2f);
                                }

                            }



                            return;
                        }
                    }

                }


            }
        }

    }



}
