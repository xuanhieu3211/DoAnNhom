using DoAnNhom;
using MCplaylist;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WMPLib;

namespace MCplaylist
{
    public class SNode
    {
        public object data;
        public SNode link;
        public SNode(object data) { this.data = data; this.link = null; }
    }
    public class SingleLinkedList
    {
        public SNode header;
        public void AddFirst(string filePath)
        {
            SNode newNode = new SNode(filePath);
            newNode.link = header.link;
            header.link = newNode;
        }
    }
    public class Playlist
    {
        private List<string> tracks = new List<string>();

        public int CurrentIndex { get; private set; } = -1;

        public void Add(string filePath)
        {
            if (filePath != null)
            {
                tracks.Add(filePath);

                if (CurrentIndex == -1)
                {
                    CurrentIndex = 0;
                }
            }
        }
        public int Count => tracks.Count;
        public string GetAt(int index) => (index >= 0 && index < tracks.Count) ? tracks[index] : null;
    }
    public class DNode
    {
        public object data;  
        public DNode next;    
        public DNode prev;    
        public DNode(object data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
   
    public class DoubleLinkedList
    {
        public DNode header;       
        public DNode currentTrack; 
        public DoubleLinkedList()
        {
            this.header = new DNode("Header"); 
            this.currentTrack = null;          
        }
        public void AddTrack(string filePath)
        {
            DNode current = header;
            while (current.next != null) current = current.next;

            DNode newNode = new DNode(filePath); 
            newNode.prev = current;              
            current.next = newNode;            
            if (currentTrack == null) currentTrack = newNode;
        }
    }
  
    public class MyPlaylistManager
    {
        private DoubleLinkedList playlist; 
        private WindowsMediaPlayer wmpEngine;
        public double GetDuration()
        {
            if (wmpEngine.currentMedia != null)
                return wmpEngine.currentMedia.duration;
            return 0;
        }
        public double GetCurrentPosition()
        {
            if (wmpEngine.currentMedia != null)
                return wmpEngine.controls.currentPosition;
            return 0;
        }

        public void SetCurrentPosition(double positionSeconds)
        {
            try
            {
                if (wmpEngine?.currentMedia != null)
                    wmpEngine.controls.currentPosition = positionSeconds;
            }
            catch
            {
                
            }
        }
        public MyPlaylistManager()
        {
            playlist = new DoubleLinkedList();
            wmpEngine = new WindowsMediaPlayer(); 
            wmpEngine.settings.autoStart = false;
        }

        public DNode Find(object value)
        {
            if (playlist == null || playlist.header == null) return null;
            DNode current = playlist.header;
            while (current != null && !object.Equals(current.data, value))
                current = current.next;
            return current;
        }
        public void Insert(object newdata, object afterelement)
        {
            DNode afterNode = Find(afterelement);
            if (afterNode != null)
            {
                DNode newNode = new DNode(newdata);
                newNode.next = afterNode.next;
                newNode.prev = afterNode;
                if (afterNode.next != null) afterNode.next.prev = newNode;
                afterNode.next = newNode;
            }
        }
        public void AddMusic(string filePath) => playlist.AddTrack(filePath);
        public void Play()
        {
            if (playlist.currentTrack != null)
            {
                wmpEngine.URL = playlist.currentTrack.data.ToString();
                wmpEngine.controls.play();
            }
        }
        public void Pause() => wmpEngine.controls.pause();

        public void NextTrack()
        {

            if (playlist.currentTrack != null && playlist.currentTrack.next != null)
            {
                playlist.currentTrack = playlist.currentTrack.next; 
                Play();
            }
        }
        public void PreviousTrack()
        {
            if (playlist.currentTrack != null && playlist.currentTrack.prev != null && playlist.currentTrack.prev != playlist.header)
            {
                playlist.currentTrack = playlist.currentTrack.prev; 
                Play(); 
            }
        }
        public void RemoveTrackAt(int index)
        {
            if (playlist.header.next == null) return; 
            DNode current = playlist.header.next;
            int count = 0;

            while (current != null)
            {
                if (count == index)
                {
                    bool isCurrentTrack = (playlist.currentTrack == current);
                    if (current.prev != null) current.prev.next = current.next;
                    if (current.next != null) current.next.prev = current.prev;
                    if (isCurrentTrack)
                    {
                        Pause(); 

                        playlist.currentTrack = null;
                    }
                    return;
                }
                count++;
                current = current.next;
            }
        }
        public void PlayTrackAt(int index)
        {
            DNode current = playlist.header.next;
            int count = 0;
            while (current != null)
            {
                if (count == index)
                {
                    playlist.currentTrack = current; 
                
                    return;
                }
                count++;
                current = current.next;
            }
        }
        public void SetCurrentTrackAt(int index)
        {
            DNode current = playlist.header.next;
            int count = 0;
            while (current != null)
            {
                if (count == index)
                {
                    playlist.currentTrack = current;
                    return;
                }
                count++;
                current = current.next;
            }
        }
    }
    internal static class Program
    {
        [STAThread] 
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}