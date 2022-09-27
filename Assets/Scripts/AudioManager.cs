using System;
using UnityEngine;

namespace Saito.Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager:SingletonMonoBehaviour<AudioManager>
    {
        [SerializeField] 
        private AudioSource source;
        
        private float duration = 0.0f;
        private float delayTime = 0.0f;

        /// <summary>
        /// 効果音を流す
        /// </summary>
        /// <param name="clip"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public AudioManager PlaySE(AudioClip clip,float duration=0.0f)
        {
            if(source==null)Debug.LogError("[Audio]AudioSourceがアタッチされていません");

            if (clip!=null) source.PlayOneShot(clip);
            else Debug.LogError("[Audio]AudioClipが設定されていません");

            return this;
        }
        
        /// <summary>
        /// BGMを再生する
        /// </summary>
        /// <param name="clip"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public AudioManager PlayBGM(AudioClip clip,float duration=0.0f,bool loopFlag=false)
        {
            if(source==null)Debug.LogError("[Audio]AudioSourceがアタッチされていません");

            if (clip != null)
            {
                source.clip = clip;
                source.loop = loopFlag;
                source.Play();
            }else Debug.LogError("[Audio]AudioClipが設定されていません");

            return this;
        }
        
        public AudioManager SetVolume(float volume)
        {
            source.volume = Math.Clamp(volume,0.0f,1.0f);
            return this;
        }
        
        public AudioManager SetPitch(float pitch)
        {
            source.pitch = Math.Clamp(pitch,-3.0f,3.0f);
            return this;
        }
        
        public AudioManager SetDelay(float delay)
        {
            this.delayTime = delay;
            return this;
        }
        
        public void OnComplete(Action _event)
        {
           _event.Invoke();
        }
    }
}