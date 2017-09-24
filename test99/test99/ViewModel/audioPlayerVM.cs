using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using test99.Services;
using Xamarin.Forms;

namespace test99.ViewModel
{

    public class audioPlayerVM : INotifyPropertyChanged

    {

        private IAudioPlayerService _audioPlayer;
       

        public audioPlayerVM(IAudioPlayerService audioPlayer)
        {
            _audioPlayer = audioPlayer;
           
        
           
        }

      //add Command for every clickable item in you UI

        private ICommand _playPauseCommand, _playSnareCommand;
        public ICommand PlayPauseCommand
        {
            get
            {
                return _playPauseCommand ?? (_playPauseCommand = new Command(
                    (obj) =>
                    {
                        
                        //add the mp3 files in the assets folder in android and ressources in ios

                                _audioPlayer.Play("Kick.mp3");
                            
                           
                            
                      
                        
                    }));
            }
        }


        public ICommand PlaySnareCommand
        {
            get
            {
                return _playSnareCommand ?? (_playSnareCommand = new Command(
                    (obj) =>
                    {

                        _audioPlayer.Play("Snare.mp3");





                    }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


    }
}












