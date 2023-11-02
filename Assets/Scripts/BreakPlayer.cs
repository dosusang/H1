using System;
using UnityEngine;

public class BreakPlayer : MonoBehaviour
{
    public Material mat;
    public bool playing = false;
    public float playTime;
    public float animTime;

    void Start()
    {
    }

    void Play()
    {
        if (playing) return;
        playing = true;
        playTime = 0;
        mat = GetComponent<MeshRenderer>().material;
        animTime = (mat.GetFloat("_frameCount")-2) / mat.GetInt("_houdiniFPS");
    }

    private void OnCollisionEnter(Collision other)
    {
        Play();
    }

    void Update()
    {
        if (playTime < animTime)
        {
            playTime += Time.deltaTime;
            mat.SetFloat("_CustomTime", playTime);
        }
    }
}
