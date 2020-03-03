using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperFlip : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Transform alicePaper;
    [SerializeField] Transform februaryPaper;
    public bool isAnimating = false;

    void OnMouseDown()
    {
    
        if(isAnimating == true) return;
        
        animator.SetTrigger("Flip");

    }

    public void AliceToFront()
    {

        alicePaper.SetAsLastSibling();

    }

    public void EndOfAnimation()
    {
        isAnimating = false;
    }

    public void AliceToBack()
    {

        alicePaper.SetAsFirstSibling();

    }
    public void StartOfAnimation()
    {
        isAnimating = true;
    }
}
