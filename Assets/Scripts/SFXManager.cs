using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] public AudioClip BlanketFluff;
    [SerializeField] public AudioClip BlanketPut;
    [SerializeField] public AudioClip BookClose;
    [SerializeField] public AudioClip BookOpen;
    [SerializeField] public AudioClip BookPut;
    [SerializeField] public AudioClip BoxScratch;
    [SerializeField] public AudioClip ClosetClose;
    [SerializeField] public AudioClip ClosetOpen;
    [SerializeField] public AudioClip DigitalClockClick;
    [SerializeField] public AudioClip DigitalClockCrash;
    [SerializeField] public AudioClip DoorOpen;
    [SerializeField] public AudioClip DrawerOpen;
    [SerializeField] public AudioClip KeypadClick;
    [SerializeField] public AudioClip KeypadPass;
    [SerializeField] public AudioClip KeypadWrong;
    [SerializeField] public AudioClip LockOpen1;
    [SerializeField] public AudioClip LockOpen2;
    [SerializeField] public AudioClip LockOpen3;
    [SerializeField] public AudioClip Marker;
    [SerializeField] public AudioClip PaperFlip1;
    [SerializeField] public AudioClip PaperFlip2;
    [SerializeField] public AudioClip PrinceBoxOpen;
    [SerializeField] public AudioClip TurnOn;
    [SerializeField] public AudioClip VaultOpen;
    [SerializeField] public AudioClip TryToOpenDoor;
    [SerializeField] public AudioClip DoorKnock;
    [SerializeField] public AudioClip LogoSFX;
    [SerializeField] public AudioClip Click;

    public void PlaySFX(AudioClip audioClip)
    {
        GetComponent<AudioSource>().PlayOneShot(audioClip);
    }
}
