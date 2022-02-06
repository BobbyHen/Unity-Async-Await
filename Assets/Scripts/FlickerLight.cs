using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public Light _lamp;
    [SerializeField] private int _randomSeconds;
    [SerializeField] private int _randomIntensity;
    public bool _isFlickered = false;

    void Update()
    { 
        if(_isFlickered == false)
            Flicker();
    }

    async void Flicker() {
        _randomSeconds = Random.Range(50, 500) * 60;
        _randomIntensity = Random.Range(2, 10);

        await Task.Delay(_randomSeconds);
        _lamp.intensity = _randomIntensity;
    }
}