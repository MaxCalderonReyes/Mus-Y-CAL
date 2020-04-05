using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class TotalScore : MonoBehaviour
{
    public List<GameObject> stars;
    public Text Score;
    private int Puntos;
    public GameObject reference;

    public Text combo;
    public int comboCounter;

    public int Points
    {
        get { return Puntos; }
        set { Puntos = value; }
    }
    void Start()
    {
        comboCounter = 0;

        for (int i = 0; i < stars.Count; i++)
        {
            stars[i].SetActive(true);
        }
    }

    private int[] scoreStamp = new int[] { 25000, 35000, 45000, 55000, 65000 };
    private int activeStars = 0;

    // Update is called once per frame
    void Update()
    {
        combo.text = comboCounter.ToString();
        if (comboCounter != 0)
        {
            combo.color = new Color(255, 255, 255, 255); 
        }
        else
        {
            combo.color = new Color(255, 255, 255, 0);
        }
        //print(Points);
        int temp = Points;
        //print(temp);

        Score.text = Points.ToString();
        /*
        if (Points > 5000)
        {
            stars[0].SetActive(true);

            if (Points > 15000)
            {
                stars[1].SetActive(true);
                if (Points > 20000)
                {
                    stars[2].SetActive(true);
                    if (Points > 25000)
                    {
                        stars[3].SetActive(true);
                        if (Points > 30000)
                        {
                            stars[4].SetActive(true);

                        }
                    }
                }
            }
        }
        */
    }

    public void spawnObject()
    {
        GameObject spawnObj = Instantiate(reference, reference.transform.position, Quaternion.identity, reference.transform);
        spawnObj.transform.localScale = new Vector3(1, 1, 1);
        StartCoroutine(scaleDownCircle(spawnObj));
    }

    IEnumerator scaleDownCircle(GameObject circle)
    {
        float currentScale = 1f;

        while (currentScale > 0f)
        {
            currentScale -= 2f * Time.deltaTime;
            circle.transform.localScale = new Vector3(currentScale, currentScale, 1);
            yield return null;
        }
        Destroy(circle.gameObject);
    }

    public void addPoints(int i)
    {
        Points += i;
        float percentage = (float)(Points - ((activeStars != 0) ? scoreStamp[activeStars - 1] : 0)) / (float)(scoreStamp[activeStars] - ((activeStars != 0) ? scoreStamp[activeStars - 1] : 0));

        stars[activeStars].GetComponent<Image>().color = Color.Lerp(Color.white, Color.yellow, percentage);

        if (Points >= scoreStamp[activeStars])
        {
            Debug.Log("newStar");
            StartCoroutine(scaleUp(stars[activeStars]));
            activeStars++;
        }
    }

    IEnumerator scaleUp(GameObject star)
    {
        float target = 40f;
        float current = 30f;

        while (current <= target)
        {
            current += Time.deltaTime * 15f;
            star.GetComponent<RectTransform>().sizeDelta = new Vector2(current, current);
            yield return null;
        }

        StartCoroutine(rotate(star));
    }

    IEnumerator rotate(GameObject star)
    {
        float target = 360f;
        float current = 0f;
        float speed = 1;

        while (current < target)
        {
            float increase = 720 * speed * Time.deltaTime;
            current += increase;
            speed -= Time.deltaTime;
            star.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, increase));
            yield return null;
        }

        StartCoroutine(scaleDown(star));
    }

    IEnumerator scaleDown(GameObject star)
    {
        float target = 30f;
        float current = 40f;

        while (current > target)
        {
            current -= Time.deltaTime * 15f;
            star.GetComponent<RectTransform>().sizeDelta = new Vector2(current, current);
            yield return null;
        }
    }
}
