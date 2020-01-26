using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioColor : AudioSyncer
{
  
	public Color[] beatColors;
	public Color restColor;

	private int m_randomIndx;
	private Color m_img;

    private Renderer holi;
    public static bool spawn;


    private void Start()
	{
        spawn = false;
		holi = GetComponent<Renderer>();
        m_img = GetComponent<Renderer>().material.color;
	}


	public override void OnBeat()
	{
        //print(m_img);
		base.OnBeat();
        spawn = true;

        holi.material.color = m_img;

        Color _c = RandomColor();

		StopCoroutine("MoveToColor");
		StartCoroutine("MoveToColor", _c);
	}


    public override void OnUpdate()
	{
      
		base.OnUpdate();

		if (m_isBeat) return;
      

		m_img = Color.Lerp(m_img, restColor, restSmoothTime*Time.deltaTime);
        
	}

    	private Color RandomColor()
	{
		if (beatColors == null || beatColors.Length == 0) return Color.white;
		m_randomIndx = Random.Range(0, beatColors.Length);
		return beatColors[m_randomIndx];
	}

    
	private IEnumerator MoveToColor(Color _target)
	{
		Color _curr = m_img;
		Color _initial = _curr;
		float _timer = 0;
		
		while (_curr != _target)
		{
			_curr = Color.Lerp(_initial, _target, _timer / timeToBeat);
			_timer += Time.deltaTime;

			m_img = _curr;

			yield return null;
		}

		m_isBeat = false;
	}



	



	
}
