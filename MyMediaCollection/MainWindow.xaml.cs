using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using MyMediaCollection.Enums;
using MyMediaCollection.Model;
using System.Net.Http.Headers;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MyMediaCollection
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private bool _isLoaded = false;
        private IList<MediaItem> _items;

        public MainWindow()
        {
            InitializeComponent();

            PopulateData();
        }
    

        public void PopulateData()
        {
                if (_isLoaded) return;
                _isLoaded = true;

                var misCDs = new MediaItem
                { Id = 1,
                    Name = "Classical Favorites",
                    MediaType = ItemType.Music,
                    MediumInfo = new Medium
                    {
                        Id = 1,
                        Name = "CD de Música",
                        MediaType = ItemType.Music
                    }
                };

                var misLibros = new MediaItem
                {
                    Id = 1,
                    Name = "Classical Fairy Tales",
                    MediaType = ItemType.Book,
                    MediumInfo = new Medium
                    {
                        Id = 1,
                        Name = "Libro",
                        MediaType = ItemType.Book
                    }
                };

                var misBlueRays = new MediaItem
                {
                    Id = 1,
                    Name = "The Mummy",
                    MediaType = ItemType.Video,
                    MediumInfo = new Medium
                    {
                        Id = 1,
                        Name = "Video en Bluray",
                        MediaType = ItemType.Video
                    }
                };

                _items = new List<MediaItem>
                {
                    misCDs,
                    misLibros,
                    misBlueRays
                };

            }

        }
}
