using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RedEyeRemover;

            photoProcessor.Process("Photo.jpg", filterHandler);
        }

        static void RedEyeRemover(Photo photo)
        {
            Console.WriteLine("Remove Red Eye");
        }
    }
}
