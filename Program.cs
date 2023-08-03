using System;
using System.Diagnostics;
using AudioSwitcher.AudioApi.CoreAudio;
namespace ChangeMicVolume // Note: actual namespace depends on the project name.
{
    internal class ChangeMicVolume
    {
        static void Main(string[] args)
        {
            {

                CoreAudioDevice DefaultCaptureDevice = new CoreAudioController().DefaultCaptureDevice;
                Console.WriteLine(DefaultCaptureDevice.FullName + " current volume of " + "is: " + DefaultCaptureDevice.Volume);
                while (true)
                {
                    try {
                    Console.ResetColor();
                    Console.WriteLine("Enter the desired volume: ");
                    int volume = Convert.ToInt32(Console.ReadLine());
                    
                 

                    void FixVolume(int volume)
                    {

                        DefaultCaptureDevice.Volume = volume;
                        Console.WriteLine(DefaultCaptureDevice.FullName + " volume has been changed to: " + volume);
                    }

                    
                    FixVolume(volume);
                    }
                    catch (Exception)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please insert only integers!");
                        
                    }
                   
                }
            }
        }
    }
}