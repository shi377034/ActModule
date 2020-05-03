namespace ActCanvas
{
    public interface IAnimationSystem
    {
        bool IsPlaying{get;}
        void Play(IAnimation animation);
        void Stop();
    }
}