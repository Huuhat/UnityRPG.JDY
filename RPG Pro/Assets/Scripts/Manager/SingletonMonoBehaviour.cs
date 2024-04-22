using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  �̱��� ������ �������� �ݺ��� �����ֱ�  ���� Ŭ����
///  �ν��Ͻ��� �����ϰ� ���� ���� �߿� �ı����� �ʵ��� ����
/// </summary>
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : Component
{
    private static T instance;
    public static T Instance => instance;

    public static T GetOrCreateInstance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType(typeof(T)) as T; // Get

            if (instance == null) 
            {
                GameObject newGameObject = new GameObject(typeof(T).Name, typeof(T));
                instance = newGameObject.GetComponent<T>();
            }
            return instance;
        }
        return instance;
    }

    protected virtual void Awake()
    {
        instance = this as T;

        if(Application.isPlaying == true )
        {
            DontDestroyOnLoad(gameObject);

        }

    }



}