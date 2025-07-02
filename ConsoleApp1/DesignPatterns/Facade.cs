namespace ConsoleApp1.DesignPatterns
{

    class DVDPlayer
    {
        public void On() => Console.WriteLine("DVD Player ON");
        public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
        public void Off() => Console.WriteLine("DVD Player OFF");
    }

    class SoundSystem
    {
        public void On() => Console.WriteLine("Sound System ON");
        public void SetVolume(int level) => Console.WriteLine($"Volume set to {level}");
        public void Off() => Console.WriteLine("Sound System OFF");
    }

    class TV
    {
        public void On() => Console.WriteLine("TV ON");
        public void SetInput(string input) => Console.WriteLine($"TV input set to {input}");
        public void Off() => Console.WriteLine("TV OFF");
    }

    class HomeTheaterFacade
    {
        private readonly DVDPlayer dvd;
        private readonly SoundSystem sound;
        private readonly TV tv;

        public HomeTheaterFacade(DVDPlayer dvd, SoundSystem sound, TV tv)
        {
            this.dvd = dvd;
            this.sound = sound;
            this.tv = tv;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Preparing to watch a movie...");
            tv.On();
            tv.SetInput("HDMI");
            sound.On();
            sound.SetVolume(20);
            dvd.On();
            dvd.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down movie setup...");
            dvd.Off();
            sound.Off();
            tv.Off();
        }
    }
}
