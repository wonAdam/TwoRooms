using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] Text speakerText;
    [SerializeField] Text contentText;
    [SerializeField] float delaySec = 0.1f;

    public bool isDialogueing = false;
    public bool isDDororo = false;
    public List<string> speakersBuffer;
    public List<string> contentsBuffer;
    [SerializeField] Animator afterDialogueTrigger = null;

    public void StartDialogue(List<KeyValuePair<string, string>> speakerNcontents, int scene_num = 0)
    {
        StopAllCoroutines();
        speakersBuffer.Clear();
        contentsBuffer.Clear();

        for(int i = 0 ; i < speakerNcontents.Count; i++)
        {
            speakersBuffer.Add(speakerNcontents[i].Key);
            contentsBuffer.Add(speakerNcontents[i].Value);
        }

        isDialogueing = true;
        dialoguePanel.SetActive(true);
        StartCoroutine(Dialogue_Coroutine(speakersBuffer[0], contentsBuffer[0]));

    }


    private IEnumerator Dialogue_Coroutine(string speaker, string content, int scene_num = 0)
    {
        isDDororo = true;
        contentText.text = "";
        speakerText.text = "";

        while(true)
        {

            speakerText.text = speaker;
            content = content.Replace("\\n", "\n");

            for(int i = 0 ; i < content.Length; i++)
            {
                contentText.text += content[i];
                yield return new WaitForSeconds(delaySec);

            }


            speakersBuffer.RemoveAt(0);
            contentsBuffer.RemoveAt(0);

            if(speakersBuffer.Count == 0)
            {

                isDialogueing = false;

            }

            isDDororo = false;
            break;

        }

    }

    public void OnClick_Dialogue()
    {
        
        if(isDialogueing == true)
        {

            if(isDDororo == true)
            {

                StopAllCoroutines();
                contentText.text = contentsBuffer[0];

                speakersBuffer.RemoveAt(0);
                contentsBuffer.RemoveAt(0);

                if(speakersBuffer.Count == 0)
                {

                    isDialogueing = false;

                }

                isDDororo = false;

            }

            else
            {

                StartCoroutine(Dialogue_Coroutine(speakersBuffer[0], contentsBuffer[0]));
                
            }

        }
        else
        {

            speakerText.text = "";
            contentText.text = "";
            gameObject.SetActive(false);

            if(afterDialogueTrigger != null)
            {
                afterDialogueTrigger.SetTrigger("NextScene");
            }
        }

    }
}
