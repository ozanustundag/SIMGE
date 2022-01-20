using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonScript : MonoBehaviour
{
    public int sayi;
    public static SingletonScript Instance { get; private set ; }
    void Start()
    {
        SecondSingletonPattern secondSingletonPattern = SecondSingletonPattern.Instance();//101
        secondSingletonPattern secondSingletonPattern1 = SecondSingletonPattern.Instance();//101
    }

    
    void Update()
    {
        
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(gameObject);      
    }
    public void Method5()
    {
        Debug.Log("Singleton method çalýþtý");
    }

    class SecondSingletonPattern
    {
        private static SecondSingletonPattern _instance;
        private SecondSingletonPattern()
        {

        }
        public static SecondSingletonPattern Instance()
        {
            if (_instance==null)
            {
                _instance = new SecondSingletonPattern();//101
            }
            return _instance;
        }
       
    }
}
