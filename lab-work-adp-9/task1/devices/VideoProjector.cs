
namespace lab_work_adp_9.task1.devices
{
    public class VideoProjector
    {
        public void TurnOn()
        {
            Console.WriteLine("Video projector is now ON.");
        }
        public void SetResolution(string resolution)
        {
            Console.WriteLine($"Video projector resolution set to {resolution}.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Video projector is now OFF.");
        }
    }
}
