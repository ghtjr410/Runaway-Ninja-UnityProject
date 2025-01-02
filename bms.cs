using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class bms : MonoBehaviour {
    public string TITLE;        // 타이틀
    public string ARTIST;       // 아티스트
    public double BPM;          // BPM
    public List<Node> noteList; // 노트 데이터 리스트
    public int totalNoteCount;  // 총 노트수
   



    void Awake()
    {
        TITLE = "";
        ARTIST = "";
        BPM = 0;
        noteList = new List<Node>();
        totalNoteCount = 0;
    }



    // get/set
    public string getTitle()
    {
        return TITLE;
    }
    public void setTitle(string TITLE)
    {
        this.TITLE = TITLE;
    }
    public string getArtist()
    {
        return ARTIST;
    }
    public void setARTIST(string ARTIST)
    {
        this.ARTIST = ARTIST;
    }
    public List<Node> getNoteList()
    {
        return noteList;
    }
    public void setNoteList(List<Node> noteList)
    {
        this.noteList = noteList;
    }
    public double getBPM()
    {
        return BPM;
    }
    public void setBpm(double BPM)
    {
        this.BPM = BPM;
    }
    public int getTotalNoteCount()
    {
        return totalNoteCount;
    }
    public void setTotalNoteCount(int totalCount)
    {
        this.totalNoteCount = totalCount; ;
    }



    // add
    public void addNote(Node note)
    {
        noteList.Add(note);
    }



    // sum
    public void sumTotalNoteCount()
    {
        this.totalNoteCount++;
    }

    
    
    // debug
    public void debug()
    {
        print("TITLE = " + TITLE);
        print("ARTIST = " + ARTIST);
        print("BPM = " + BPM);
        print("noteList = " + noteList.Count);
        print("totalNoteCount = " + totalNoteCount);
        
    }
    

   

}
