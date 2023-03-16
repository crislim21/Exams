using Exams.Models;
using System.Net.Http;
using System.Text.Json;

namespace Exams
{
    public partial class Form1 : Form
    {
        private const string IncorrectInputTitle = "Incorrect Input";
        public Form1()
        {
            InitializeComponent();
        }
        private async void GenerateButton_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                // This for genre 
                string urlGenre = "https://api.exam.nanao.moe/api/genre/";
                var responseGenre = await httpClient.GetAsync(urlGenre);

                responseGenre.EnsureSuccessStatusCode();
                var resultGenre = await responseGenre.Content.ReadAsStreamAsync();

                var resultDataGenre = System.Text.Json.JsonSerializer.Deserialize<List<GenreData>>(resultGenre);
                if (resultGenre == null)
                {
                    MessageBox.Show("conversion failed.", "Fetch API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var genreSource = new BindingSource
                {
                    DataSource = resultDataGenre
                };

                // This for Song
                string urlSong = "https://api.exam.nanao.moe/api/song/";
                var responseSong = await httpClient.GetAsync(urlSong);

                responseSong.EnsureSuccessStatusCode();
                var resultSong = await responseSong.Content.ReadAsStreamAsync();

                var resultDataSong = System.Text.Json.JsonSerializer.Deserialize<List<SongData>>(resultSong);
                if (resultSong == null)
                {
                    MessageBox.Show("conversion failed.", "Fetch API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var songSource = new BindingSource
                {
                    DataSource = resultDataSong
                };

                songBox.DataSource = songSource;
                songBox.DisplayMember = "title";
                idSong.DataSource = songSource;
                idSong.DisplayMember = "id";

                genreBox.DataSource = genreSource;
                genreBox.DisplayMember = "name";
                idGenre.DataSource = genreSource;
                idGenre.DisplayMember = "id";

                comboBoxInput.DataSource = genreSource;
                comboBoxInput.DisplayMember = "name";

            }

        }

        private async void RefreshSongs_Click(object sender, EventArgs e)
        {
            using (var httpClient = new HttpClient())
            {
                // This for genre 
                string urlGenre = "https://api.exam.nanao.moe/api/genre/";
                var responseGenre = await httpClient.GetAsync(urlGenre);

                responseGenre.EnsureSuccessStatusCode();
                var resultGenre = await responseGenre.Content.ReadAsStreamAsync();

                var resultDataGenre = System.Text.Json.JsonSerializer.Deserialize<List<GenreData>>(resultGenre);
                if (resultGenre == null)
                {
                    MessageBox.Show("conversion failed.", "Fetch API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var genreSource = new BindingSource
                {
                    DataSource = resultDataGenre
                };

                // This for Song
                string urlSong = "https://api.exam.nanao.moe/api/song/";
                var responseSong = await httpClient.GetAsync(urlSong);

                responseSong.EnsureSuccessStatusCode();
                var resultSong = await responseSong.Content.ReadAsStreamAsync();

                var resultDataSong = System.Text.Json.JsonSerializer.Deserialize<List<SongData>>(resultSong);
                if (resultSong == null)
                {
                    MessageBox.Show("conversion failed.", "Fetch API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var songSource = new BindingSource
                {
                    DataSource = resultDataSong
                };

                songBox.DataSource = songSource;
                songBox.DisplayMember = "title";
                idSong.DataSource = songSource;
                idSong.DisplayMember = "id";

                genreBox.DataSource = genreSource;
                genreBox.DisplayMember = "name";
                idGenre.DataSource = genreSource;
                idGenre.DisplayMember = "id";

                comboBoxInput.DataSource = genreSource;
                comboBoxInput.DisplayMember = "name";
            }
        }

        private async void AddSong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleInput.Text))
            {
                MessageBox.Show("Please input the song title.",
                    IncorrectInputTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(artistInput.Text))
            {
                MessageBox.Show("Please input the song artist.",
                    IncorrectInputTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxInput.Text))
            {
                MessageBox.Show("Please choose the song genre.",
                    IncorrectInputTitle, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            bool isAvailable;
            if (trueValueBox.Checked)
            {
                isAvailable = true;
            }
            else if (falseValueBox.Checked)
            {
                isAvailable = false;
            }
            else
            {
                MessageBox.Show("Please input your artist availability.",
                    IncorrectInputTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int totalLength = minuteInput.Text.Length * 60 + secondInput.Text.Length;
            var addSong = new SongData
            {
                
                Title = titleInput.Text,
                Artist = artistInput.Text,
                GenreName = comboBoxInput.Text,
                Length = totalLength,
                ReleaseDate = releaseDateInput.Text,
                IsAvailable = isAvailable,

            };
            var urlAdd = "https://api.exam.nanao.moe/api/song/create/";
            using (var addSongJsonStream = new MemoryStream())
            {
                await JsonSerializer.SerializeAsync(addSongJsonStream, addSong);
                using(var content = new StreamContent(addSongJsonStream))
                {
                    content.Headers.Add("Content-Type", "application/json");
                    using(var httpClient = new HttpClient())
                    {
                        var response = await httpClient.PostAsync(urlAdd, content);
                        response.EnsureSuccessStatusCode();
                        using(var result = await response.Content.ReadAsStreamAsync())
                        {
                            var addSongs = await JsonSerializer.DeserializeAsync<List<SongData>>(result);
                            if(addSongs == null)
                            {
                                MessageBox.Show("Return result is null");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Song Success added");
                            }
                        }
                    }
                    
                }
                
            }
        }
    }
}