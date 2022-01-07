using UnityEngine;

public class DebuggerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log($"使用Logger打印日志的话，请先打开Debugger宏");
    }

    float time = 0;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > 10)
        {
            time = 0;
//#if Debugger
//            Logger.Log($"real time since start up: {Time.realtimeSinceStartup}s");
//            Logger.Warning($"real time since start up: {Time.realtimeSinceStartup}s");
//            Logger.Error($"real time since start up: {Time.realtimeSinceStartup}s");
//#else
            Debug.Log($"real time since start up: {Time.realtimeSinceStartup} s");
            Debug.LogWarning($"real time since start up: {Time.realtimeSinceStartup} s");
            Debug.LogError($"real time since start up: {Time.realtimeSinceStartup} s");
//#endif
        }
    }
}
