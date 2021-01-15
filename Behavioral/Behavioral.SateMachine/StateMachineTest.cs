using Behavioral.StateMachine;
using Behavioral.StateMachine.AudioPlayerStates;
using System;
using System.Linq;
using Xunit;

namespace Behavioral.StateMachine
{
    public class StateMachineTest

    {
        [Fact]
        public void Test1()
        {
            // arrange 
            var playList = new string[] {
                "Song 1",
                "Song 2",
                "Song 3",
                "Song 4",
            };
            var player = new AudioPlayer(playList.ToList());

            // act 
            player.ClickPlay();
            player.ClickLock();

            // assert 
            Assert.IsType<AudioPlayerLockedState>( player._state);

        }
    }
}
