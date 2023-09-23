using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.Day3
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent() //only virtual methods can be over ridden in child class
        {
            Console.WriteLine("Start");
        }
        public virtual void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
        public void ContinuePlayingContent()
        {
            Console.WriteLine("Continue");
        }
        internal class AudioContent : MediaContent
        {
            public override sealed void StartPlayingContent() //sealed will prevent over ridding the method by the grandchild class
            {
                Console.WriteLine("Start from AudioContent");
            }
        }
        //END OF AudioContent
        internal class VideoContent : AudioContent
        {
           // public override void StartPlayingContent()
            //{
              //  Console.WriteLine("Start");
            //}
        }
        //END OF VideoContent 


    }
}
