using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace DOT_Number_Reading
{
    public class ImageHandler
    {
        // Directory for storing images
        public string ImagesDirectory { get; private set; } = @"C:\DOTNumberReading\img\test\Result";

        // Save image to the specified file path
        public void SaveImage(string filePath, byte[] imageData)
        {
            File.WriteAllBytes(filePath, imageData);
        }

        // Display the most recent image in the picture box
        public void DisplayImage(PictureBox pictureBox)
        {
            // Get the most recent .jpg file path from OK and NG folders
            var allFiles = Directory.GetFiles(Path.Combine(ImagesDirectory, "OK"), "*.jpg")
                                    .Concat(Directory.GetFiles(Path.Combine(ImagesDirectory, "NG"), "*.jpg"))
                                    .OrderByDescending(file => File.GetLastWriteTime(file))
                                    .FirstOrDefault();

            if (!string.IsNullOrEmpty(allFiles) && File.Exists(allFiles))
            {
                using (var stream = new FileStream(allFiles, FileMode.Open, FileAccess.Read))
                {
                    pictureBox.Image = Image.FromStream(stream); // Load and display image
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }
    }
}