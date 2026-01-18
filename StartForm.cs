using System.Numerics;
using System.Text.Json;
using System.Xml.Linq;

namespace QzX
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            players = GetPlayerList(statsPath);
        }

       static List<Player> GetPlayerList(string filePath)
        {

            List<Player> players;

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                players = JsonSerializer.Deserialize<List<Player>>(json) ?? new List<Player>();
            }
            else
            {
                players = new List<Player>();
            }
            return players;

        }

        static void GetPlayer(List<Player> players, string name)
        {

            // пробуем найти игрока
            Player player = players.FirstOrDefault(p => p.Name == name);

            // если нет Ц создаЄм нового
            if (player == null)
            {
                int maxId = 0;
                if (players.Any())
                {
                    maxId = players.Max(p => p.Id) + 1;
                }
                player = new Player { Id = maxId, Name = name, Games = 0, Points = 0 };
                players.Add(player);
            }

        }

        List<string> playerNames = new List<string>();
        string statsPath = "config//stats.json";
        List<Player> players;

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            TextBox[] textBoxes = { txtPlayer1, txtPlayer2, txtPlayer3, txtPlayer4, txtPlayer5, txtPlayer6, txtPlayer7 };

            foreach (var tb in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                    break;
                playerNames.Add(tb.Text.Trim());
            }

            for (int i = 0; i < playerNames.Count; i++)
            {
                GetPlayer(players, playerNames[i]);
            }

            for (int i = 0; i < playerNames.Count; i++)
            {
                Player player = players.FirstOrDefault(p => p.Name == playerNames[i]);
                startTable.Rows.Add(player.Id, player.Name, player.Games, player.Points);
            }
            btnStart.Enabled = true;
            pnlCreateGame.Enabled = false;
        }

        private void btnStartNew_Click(object sender, EventArgs e)
        {
            pnlCreateGame.Enabled = true;
            btnChooseExistingGame.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            PlayField main = new PlayField(players, playerNames, statsPath);
            this.Hide();
            main.ShowDialog();

            this.Close();
        }
    }
}