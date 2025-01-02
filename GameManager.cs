using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public GameObject notePrefab;
    public RectTransform noteLayer;
    public RectTransform[] targets;
    public RectTransform[] slots;
    static GameManager m_Instance;

    List<GameObject> m_NoteList = new List<GameObject>();


    public static GameManager instance
    {
        get
        {
            if (null == m_Instance)
                m_Instance = GameObject.FindObjectOfType(typeof(GameManager)) as GameManager;

            return m_Instance;
        }
    }


    public void CreateNote(int slot)
    {
        GameObject go = Instantiate<GameObject>(notePrefab);
    
        go.transform.SetParent(noteLayer);
        go.transform.localPosition = slots[slot].localPosition;

        m_NoteList.Add(go);

        Node node = go.GetComponent<Node>();

        if( null != node )
        {
            Vector2 dir = targets[0].localPosition - slots[slot].localPosition;

            node.Initialize(dir);
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateNote(0);
        }
    }

    public void IsCollision(GameObject go)
    {
        for(int i = 0; i < m_NoteList.Count; i++)
        {
            if( go == m_NoteList[i])
            {
                Destroy(go);

                m_NoteList.RemoveAt(i);
                break;
            }
        }
    }
}
