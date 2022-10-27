using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Profiling;
using System.IO;
using System.Text;


public class Profilling : MonoBehaviour
{
    string statsText;
    ProfilerRecorder systemMemoryRecorder;
    ProfilerRecorder gcMemoryRecorder;
    ProfilerRecorder mainThreadTimeRecorder;
    private int lastFrameIndex;
    private float[] frameDeltaTimeArray;

    private void Awake()
    {
        frameDeltaTimeArray = new float[50];
          
    }

    public TMPro.TextMeshProUGUI m_StatsText;
    static double GetRecorderFrameAverage(ProfilerRecorder recorder)
    {
        var samplesCount = recorder.Capacity;
        if (samplesCount == 0)
            return 0;

        double r = 0;
        
            var samples = new List<ProfilerRecorderSample>(samplesCount);
            recorder.CopyTo(samples);
            for (var i = 0; i < samples.Count; ++i)
            r += samples[i].Value;
            r /= samplesCount;
        

        return r;
    }

    void OnEnable()
    {
        systemMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "System Used Memory");
        gcMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "GC Reserved Memory");
        mainThreadTimeRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Internal, "Main Thread", 15);
        
    
   
    
    }

    void OnDisable()
    {
        systemMemoryRecorder.Dispose();
        gcMemoryRecorder.Dispose();
        mainThreadTimeRecorder.Dispose();
    }






    void Update()
    {
        ArrayRounder();
        var sb = new StringBuilder(500);
        sb.AppendLine($"Frame Time: {GetRecorderFrameAverage(mainThreadTimeRecorder) * (1e-6f):F1} ms");
        sb.AppendLine($"GC Memory: {gcMemoryRecorder.LastValue / (1024 * 1024)} MB");
        sb.AppendLine($"System Memory: {systemMemoryRecorder.LastValue / (1024 * 1024)} MB");
        sb.AppendLine($"FPS : {Mathf.RoundToInt(CalculateFPS()).ToString()} Frame");
        //statsText = sb.ToString();
        m_StatsText.text = sb.ToString();  
    }

    void ArrayRounder()
    {
        frameDeltaTimeArray[lastFrameIndex] = Time.deltaTime;
        lastFrameIndex = (lastFrameIndex + 1) % frameDeltaTimeArray.Length;

    }
    
    
    private float CalculateFPS()
    {
        float total = 0f;
        foreach(float deltaTime in frameDeltaTimeArray)
        {
            total += deltaTime;

        }

        return frameDeltaTimeArray.Length / total;
    }
    
    
    
    /* void OnGUI()
    {
        GUI.TextArea(new Rect(10, 30, 250, 50), statsText);
    }*/
}