using System;
using UnityEngine;

namespace Audio
{
    public interface ISound
    {
        public interface IPlay
        {
            /// <summary>
            /// 効果音を流す
            /// </summary>
            /// <param name="clip"></param>
            /// <param name="duration"></param>
            /// <returns></returns>
            public AudioManager PlaySE(AudioClip clip, float duration = 0.0f);

            /// <summary>
            /// BGMを再生する
            /// </summary>
            /// <param name="clip"></param>
            /// <param name="duration"></param>
            /// <returns></returns>
            public AudioManager PlayBGM(AudioClip clip, float duration = 0.0f, bool loopFlag = false);
        }

        public interface ISet
        {
            /// <summary>
            /// 音量を調整する
            /// </summary>
            /// <param name="volume"></param>
            /// <returns></returns>
            public AudioManager SetVolume(float volume);

            /// <summary>
            /// 音を何秒後に再生するか調整する
            /// </summary>
            /// <param name="delay"></param>
            /// <returns></returns>
            public AudioManager SetDelay(float delay);

            /// <summary>
            /// 音のピッチを調整する
            /// </summary>
            /// <param name="pitch"></param>
            /// <returns></returns>
            public AudioManager SetPitch(float pitch);
        }

        public interface IResult
        {
            /// <summary>
            /// 実行完了後に行いたいこと
            /// </summary>
            /// <param name="_event"></param>
            public void OnCompleted(Action _event);
        }
    }
}
