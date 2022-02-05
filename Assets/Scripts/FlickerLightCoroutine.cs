using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLightCoroutine : MonoBehaviour
{
    public Light _lamp;
    [SerializeField] private float _randomSeconds;
    [SerializeField] private int _randomIntensity;
    public bool _isFlickered = false;

    void Update()
    {
        if(_isFlickered == false)
            StartCoroutine(Flicker());
    }

    IEnumerator Flicker() {
        _randomSeconds = Random.Range(0.05f, 0.5f);
        _randomIntensity = Random.Range(2, 10);

        yield return new WaitForSeconds(_randomSeconds);
        _lamp.intensity = _randomIntensity;
        StopAllCoroutines();
    }
}