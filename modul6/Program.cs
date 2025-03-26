
using modul6;

static void Main(string[]args)
{
    SayaTubeUser user = new SayaTubeUser("Raditya");

    SayaTubeVideo vid1 = new SayaTubeVideo("Lovely Runner");
    SayaTubeVideo vid2 = new SayaTubeVideo("Queen Of Tears");
    SayaTubeVideo vid3 = new SayaTubeVideo("Solo Leveling");
    SayaTubeVideo vid4 = new SayaTubeVideo("Haikyuu!!!");
    SayaTubeVideo vid5 = new SayaTubeVideo("Hitman Reborn");
    SayaTubeVideo vid6 = new SayaTubeVideo("BloodHounds");
    SayaTubeVideo vid7 = new SayaTubeVideo("Taxi Driver");
    SayaTubeVideo vid8 = new SayaTubeVideo("Sakamoto Days");
    SayaTubeVideo vid9 = new SayaTubeVideo("Elite Class");
    SayaTubeVideo vid10 = new SayaTubeVideo("All Of Us Are Dead");

    user.addVideo(vid1);
    user.addVideo(vid2);
    user.addVideo(vid3);
    user.addVideo(vid4);
    user.addVideo(vid5);
    user.addVideo(vid6);
    user.addVideo(vid7);
    user.addVideo(vid8);
    user.addVideo(vid9);
    user.addVideo(vid10);

    user.printAllVideoPlayCount();
}