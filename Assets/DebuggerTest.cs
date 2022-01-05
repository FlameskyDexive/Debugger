using UnityEngine;

public class DebuggerTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"使用Logger打印日志的话，请先打开Debugger宏");
    }

    float index = 0;
    // Update is called once per frame
    void Update()
    {
        index += Time.deltaTime;
        if (index > 10)
        {
            index = 0;
#if Debugger
            Logger.Log($"real time since start up: {Time.realtimeSinceStartup}s");
            Logger.Warning($"real time since start up: {Time.realtimeSinceStartup}s");
            Logger.Error($"real time since start up: {Time.realtimeSinceStartup}s");
#else
            Debug.Log($"real time since start up: {Time.realtimeSinceStartup}s");
            Debug.LogWarning($"real time since start up: {Time.realtimeSinceStartup}s");
            Debug.LogError($"real time since start up: {Time.realtimeSinceStartup}s");
#endif
        }
    }
}
