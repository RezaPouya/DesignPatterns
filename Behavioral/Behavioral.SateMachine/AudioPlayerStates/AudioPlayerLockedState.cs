namespace Behavioral.StateMachine.AudioPlayerStates
{
    public class AudioPlayerLockedState : AudioPlayerState
    {
        public AudioPlayerLockedState(AudioPlayer audioPlayer) : base(audioPlayer)
        { }

        // When you unlock a locked player, it may assume one of two
        // states.
        public override void ClickLock()
        {
            // do nothing 
            //if (player.playing)
            //    player.changeState(new PlayingState(player))
            //else
            //    player.changeState(new ReadyState(player))

        }

        public override void ClickNext()
        {
            // do nothing
        }

        public override void ClickPlay()
        {
           // donthing 
        }

        public override void ClickPrevious()
        {
            // do nothing
        }
    }
}