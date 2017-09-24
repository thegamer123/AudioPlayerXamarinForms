using System;


namespace test99.Services
{
    

        public interface IAudioPlayerService
        
        {

        //you can add other method  check the MediaPlayer in android and AVAudioPlayer in ios

            void Play(string pathToAudioFile);
            void Play();
            void Pause();

            bool? isplaying();

            Action OnFinishedPlaying { get; set; }
        }

    }

