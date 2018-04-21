using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            IRecordable recorder = new Player();
            recorder.Record();
            recorder.Pause();
            recorder.Stop();
            Player originalPlayer = new Player();
            originalPlayer.Play();
            originalPlayer.Record();
            ((IPlayable)originalPlayer).Pause();
            ((IRecordable)originalPlayer).Pause();
            ((IPlayable)originalPlayer).Stop();
            ((IRecordable)originalPlayer).Stop();
            Console.ReadKey();
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player:IPlayable,IRecordable  
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Player paused");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Recorder paused");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Player stoped");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Recorder stoped");
        }
    }
}
