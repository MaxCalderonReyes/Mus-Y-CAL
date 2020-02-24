using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioColor : AudioSyncer
{
  
	public Color[] beatColors;
	public Color restColor;

	private int m_randomIndx;
	private Image m_img;
   
  
    public static bool spawn;


    private void Start()
	{
        spawn = false;
	
        m_img = GetComponent<Image>();
    
	}


	public override void OnBeat()
	{
        //print(m_img);
		base.OnBeat();
        spawn = true;

       

        Color _c = RandomColor();

		StopCoroutine("MoveToColor");
		StartCoroutine("MoveToColor", _c);
	}


    public override void OnUpdate()
	{
      
		base.OnUpdate();

		if (m_isBeat) return;
      

		m_img.color = Color.Lerp(m_img.color, restColor, restSmoothTime*Time.deltaTime);
        
	}

    	private Color RandomColor()
	{
		if (beatColors == null || beatColors.Length == 0) return Color.white;
		m_randomIndx = Random.Range(0, beatColors.Length);
		return beatColors[m_randomIndx];
	}

    
	private IEnumerator MoveToColor(Color _target)
	{
		Color _curr = m_img.color;
		Color _initial = _curr;
		float _timer = 0;
		
		while (_curr != _target)
		{
			_curr = Color.Lerp(_initial, _target, _timer / timeToBeat);
			_timer += Time.deltaTime;

			m_img.color = _curr;

			yield return null;
		}

		m_isBeat = false;
	}



	



	
}
