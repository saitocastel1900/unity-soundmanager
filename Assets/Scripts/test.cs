using UnityEngine;
using UniRx;
using Audio;

public class test:MonoBehaviour
    {
        [SerializeField] private AudioClip _clip;
        [SerializeField] private float _volume;
        
        private void Start()
        {
            Observable.EveryUpdate()
                .Where(_ => Input.GetKeyDown(KeyCode.A))
                .Subscribe(_ =>
                {
                    AudioManager.Instance.SetDelay(0.0f)
                        .SetPitch(1.0f)
                        .SetVolume(_volume)
                        .PlaySE(_clip)
                        .OnCompleted(() => Debug.Log("OnCompleted!"));

                }).AddTo(this);
        }
    }