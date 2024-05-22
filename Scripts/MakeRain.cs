using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeRain : MonoBehaviour
{
    private float rainPeriod = 1f;
    private float rainGravity = 1f;
    [SerializeField] private GameObject RainPrefab;

    private void Start()
    {
        InvokeRepeating("SummonRain",0, 1/rainPeriod);
    }

    public void SummonRain()
    {
        GameObject rain = Instantiate(RainPrefab);
        rain.transform.position = new Vector2(Random.Range(-2.8f, 2.8f), 5f);
        rain.GetComponentInChildren<Rigidbody2D>().gravityScale = Random.Range(1f,rainGravity);

    }
    public void LevelUp()
    {
        rainPeriod += 0.5f;
        rainGravity += 0.5f;
        CancelInvoke();
        InvokeRepeating("SummonRain",0, 1/rainPeriod);
    }
}
