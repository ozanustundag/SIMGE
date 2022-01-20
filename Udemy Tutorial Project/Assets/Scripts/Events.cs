using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Events : MonoBehaviour
{
    //public delegate void myDelegate();
    //public event myDelegate myEvent;
    public event Action myEvent;
    [SerializeField] UnityEvent unityEvent;
    int x;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void Awake()
    {
       
    }
    void OnEnable()
    {
        myEvent += Method1;
        myEvent();
        unityEvent.Invoke();
        SingletonScript.Instance.Method5();
    }
    private void OnDisable()
    {
        myEvent -= Method1;
    }

    private void Method1()
    {
        Debug.Log("Event Gerçekliþti");
    }
    public void Method2()
    {
        Debug.Log("Unity Event Gerçekliþti");
    }
    public void dkaþslf()
    {

    }
}
