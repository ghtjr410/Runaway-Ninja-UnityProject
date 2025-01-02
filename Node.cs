using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Node : MonoBehaviour
{
    public int bar;             // 마디 넘버
    public int channel;         // 채널 넘버
    public List<int> noteData;  // 노트 정보
   
    public int speed = 1;
    public int slot;
    public int index = 0;
    GameObject node1;
    GameObject node2;
    Vector2 m_dir;

    bool m_IsMove = false;

    RectTransform m_Rect;

    // Use this for initialization
    void Awake()
    {
        bar = 0;
        channel = 0;
        noteData = new List<int>();
    }

    public int getBar()
    {
        return bar;
    }
    public void setBar(int bar)
    {
        this.bar = bar;
    }
    public int getChannel()
    {
        return channel;
    }
    public void setChannel(int channel)
    {
        this.channel = channel;
    }
    public List<int> getNoteData()
    {
        return noteData;
    }
    public void setNoteData(List<int> noteData)
    {
        this.noteData = noteData;
    }
    // debug
    public void debug()
    {
        print("bar = " + bar);
        print("channel = " + channel);
        foreach (int note in noteData)
        {
            print("note = " + note);
        }
    }
    
   
    void Start()
    {
        m_Rect = this.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (true == m_IsMove)
        {
            m_Rect.Translate(m_dir * speed * Time.deltaTime);
        }
    }

    public void Initialize(Vector2 dir)
    {
        m_dir = dir;

        m_IsMove = true;
    }


}