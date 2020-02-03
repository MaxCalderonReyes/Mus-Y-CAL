using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Json 
{
  
    public List<float> Song;
    public List<prove> ColectionSongs;

   
    public Json(List<float> _Song)
    {
        Song= _Song;
    }
    public Json(List<prove> _colectionSong, int OnList)
    {
        ColectionSongs[OnList]=_colectionSong[OnList];
    }
       
}
