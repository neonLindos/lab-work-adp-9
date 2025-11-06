using lab_work_adp_9.task1;
using lab_work_adp_9.task1.devices;
using lab_work_adp_9.task2;


void TestTask1()
{
    AudioSystem audio = new AudioSystem();
    VideoProjector video = new VideoProjector();
    LightingSystem lights = new LightingSystem();

    // Create facade
    HomeTheaterFacade homeTheater = new HomeTheaterFacade(audio, video, lights);

    // Start the movie
    homeTheater.StartMovie();

    Console.WriteLine();

    // End the movie
    homeTheater.EndMovie();

}

void TestTask2()
{
    DDirectory root = new DDirectory("Root");
    FFile file1 = new FFile("File1.txt");
    FFile file2 = new FFile("File2.txt");

    DDirectory subDir = new DDirectory("SubDirectory");
    FFile subFile1 = new FFile("SubFile1.txt");

    // Формирование структуры компоновщика
    root.Add(file1);
    root.Add(file2);
    subDir.Add(subFile1);
    root.Add(subDir);

    // Отображение структуры файловой системы
    root.Display(1);

}


TestTask1();