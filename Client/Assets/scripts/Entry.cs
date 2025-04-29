using System.Collections;
using System.Collections.Generic;
using Fantasy;
using UnityEngine;
using Fantasy.Async;

public class Entry : MonoBehaviour
{
    Scene scene;
    
    // Start is called before the first frame update
    void Start()
    {
        //初始化框架
        Fantasy.Platform.Unity.Entry.Initialize(GetType().Assembly);
        StartAsync().Coroutine();
    }

    private async FTask StartAsync()
    {
        //创建一个游戏scene
        scene = await Fantasy.Platform.Unity.Entry.CreateScene();
        //scene = await Fantasy.Platform.Unity.Entry.CreateScene();
       
    }
}
