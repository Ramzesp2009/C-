using System.Windows;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace DateParallelismWithForEach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CancellationTokenSource _cancelToken = new CancellationTokenSource();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            _cancelToken.Cancel();
        }

        private void cmdProcess_Click(object sender, EventArgs eventArgs)
        {
            Task.Factory.StartNew(() => ProcessFiles());
            ProcessFiles();
            this.Title = "Processing Complete";
        }

        private void ProcessFiles()
        {
            ParallelOptions parOpts = new ParallelOptions();
            parOpts.CancellationToken = _cancelToken.Token;
            parOpts.MaxDegreeOfParallelism = System.Environment.ProcessorCount;

            var basePath = "E:/Wallfoto/New";
            //var pictureDirectory = Path.Combine(basePath, "TestPictures");
            //var outputDirectory = Path.Combine(basePath, "ModifiedPictures");
            string[] files = Directory.GetFiles(@"E:/Wallfoto/New", "*.jpg", SearchOption.AllDirectories);
            string outputDirectory = @"E:/Wallfoto/ModifiedPictures";

            if (Directory.Exists(outputDirectory))
            {
                Directory.Delete(outputDirectory, true);
            }

            Directory.CreateDirectory(outputDirectory);

            //foreach (string currentFile in files)
            //{
            //    string fileName = System.IO.Path.GetFileName(currentFile);
            //    this.Title = $"Processing {fileName} on thread {Thread.CurrentThread.ManagedThreadId}";
            //    using (Bitmap bitmap = new Bitmap(currentFile))
            //    {
            //        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            //        bitmap.Save(System.IO.Path.Combine(outputDirectory, fileName));
            //    }
            //}

            try
            {
                Parallel.ForEach(files, parOpts, currentFile =>
                {
                    parOpts.CancellationToken.ThrowIfCancellationRequested();
                    string filename = Path.GetFileName(currentFile);
                    Dispatcher?.Invoke(() =>
                    {
                        this.Title = $"Processing {filename} on thread {Thread.CurrentThread.ManagedThreadId}";
                    });
                    using (Bitmap bitmap = new Bitmap(currentFile))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(outputDirectory, filename));
                    }
                });
                Dispatcher?.Invoke(() => this.Title = "Done!");
            }
            catch (OperationCanceledException ex)
            {
                Dispatcher?.Invoke(() => this.Title = ex.Message);
            }

        }
    }
}