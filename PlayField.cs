using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QzX
{

    public partial class PlayField : Form
    {
        private List<Player> players;
        private List<string> playerNames;
        private string statsPath;
        private string[] themes;
        private List<Question> questions = new List<Question>();
        private int currentPlayer = 0;
        private Question currentQuestion;
        private bool answerResult = false;
        private int[] playerPoints;

        

        public PlayField(List<Player> players, List<string> playerNames, string statsPath)
        {
            InitializeComponent(); // обязательный вызов
            Logger.LogStart();
            this.players = players;
            this.playerNames = playerNames;
            this.statsPath = statsPath;
            playerPoints = TableCreate(playerNames);

            btnAns1.Tag = 1;
            btnAns2.Tag = 2;
            btnAns3.Tag = 3;
            btnAns4.Tag = 4;

            btnAns1.Click += AnswerButton_Click;
            btnAns2.Click += AnswerButton_Click;
            btnAns3.Click += AnswerButton_Click;
            btnAns4.Click += AnswerButton_Click;

            btn1Easy.Tag = (themeIndex: 0, difficulty: 1);
            btn1Med.Tag = (themeIndex: 0, difficulty: 2);
            btn1Hard.Tag = (themeIndex: 0, difficulty: 3);

            btn2Easy.Tag = (themeIndex: 1, difficulty: 1);
            btn2Med.Tag = (themeIndex: 1, difficulty: 2);
            btn2Hard.Tag = (themeIndex: 1, difficulty: 3);

            btn3Easy.Tag = (themeIndex: 2, difficulty: 1);
            btn3Med.Tag = (themeIndex: 2, difficulty: 2);
            btn3Hard.Tag = (themeIndex: 2, difficulty: 3);

            btn4Easy.Tag = (themeIndex: 3, difficulty: 1);
            btn4Med.Tag = (themeIndex: 3, difficulty: 2);
            btn4Hard.Tag = (themeIndex: 3, difficulty: 3);

            btn5Easy.Tag = (themeIndex: 4, difficulty: 1);
            btn5Med.Tag = (themeIndex: 4, difficulty: 2);
            btn5Hard.Tag = (themeIndex: 4, difficulty: 3);

            btn6Easy.Tag = (themeIndex: 5, difficulty: 1);
            btn6Med.Tag = (themeIndex: 5, difficulty: 2);
            btn6Hard.Tag = (themeIndex: 5, difficulty: 3);

            btn7Easy.Tag = (themeIndex: 6, difficulty: 1);
            btn7Med.Tag = (themeIndex: 6, difficulty: 2);
            btn7Hard.Tag = (themeIndex: 6, difficulty: 3);

            btn1Easy.Click += TopicButton_Click;
            btn1Med.Click += TopicButton_Click;
            btn1Hard.Click += TopicButton_Click;

            btn2Easy.Click += TopicButton_Click;
            btn2Med.Click += TopicButton_Click;
            btn2Hard.Click += TopicButton_Click;

            btn3Easy.Click += TopicButton_Click;
            btn3Med.Click += TopicButton_Click;
            btn3Hard.Click += TopicButton_Click;

            btn4Easy.Click += TopicButton_Click;
            btn4Med.Click += TopicButton_Click;
            btn4Hard.Click += TopicButton_Click;

            btn5Easy.Click += TopicButton_Click;
            btn5Med.Click += TopicButton_Click;
            btn5Hard.Click += TopicButton_Click;

            btn6Easy.Click += TopicButton_Click;
            btn6Med.Click += TopicButton_Click;
            btn6Hard.Click += TopicButton_Click;

            btn7Easy.Click += TopicButton_Click;
            btn7Med.Click += TopicButton_Click;
            btn7Hard.Click += TopicButton_Click;

            questions = qLoad();   // корректный вызов

            themes = Question.GetThemes(questions);
            OpenThemes(themes);
            UpdateQuestionButtons();
            ShowTable();

        }

        private void UpdateFile()
        {
            string saveJson = JsonSerializer.Serialize(players, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(statsPath, saveJson);
        }

        private void UpdateList()
        {
            for (int i = 0; i < playerNames.Count; i++)
            {
                Player player = players.FirstOrDefault(p => p.Name == playerNames[i]);
                player.Games++;
                player.Points += playerPoints[i];
            }
        }

        private void UpdateQuestionButtons()
        {
            foreach (Control ctrl in tblThemes.Controls)
            {
                if (ctrl is not Button btn)
                    continue;

                if (btn.Tag is not ValueTuple<int, int> tag)
                    continue;

                if (tag.Item1 < 0 || tag.Item1 >= themes.Length)
                    continue;

                string theme = themes[tag.Item1];

                int difficulty = tag.Item2;

                int remaining = questions.Count(q =>
                    q.Theme == theme &&
                    q.Level == difficulty &&
                    !q.Used
                );

                btn.Text = remaining.ToString();
                btn.Enabled = remaining > 0;
                if (questions.Count(q => !q.Used) == 0)
                {
                    btnSaveStat.Visible = true;
                    continue;
                }
            }
        }

        private void ShowTable()
        {
            Color[] color = { Color.Green, Color.DarkCyan, Color.Crimson, Color.DarkMagenta, Color.Black, Color.DarkGoldenrod, Color.BlueViolet };
            tblMainTable.Rows.Clear();
            for (int i = 0; i < playerNames.Count; i++)
            {
                tblMainTable.Rows.Add(playerNames[i], playerPoints[i]);
                tblMainTable.Rows[i].DefaultCellStyle.ForeColor = color[i];
            }
            tblMainTable.Rows[currentPlayer].Cells[2].Value = "@";
        }

        private void NextPlayer()
        {
            currentPlayer++;
            if (currentPlayer == playerPoints.Length)
            {
                currentPlayer = 0;
            }
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {

            if (sender is not Button btn) return;
            int value = currentQuestion?.Value ?? 0;
            int answer = Convert.ToInt32(btn.Tag);
            int corrAns = currentQuestion?.CorrectAnswer ?? -1;
            if (corrAns == answer)
            {
                answerResult = true;
                playerPoints[currentPlayer] += value;
                NextPlayer();
            }
            else { 
                answerResult = false; 
                value = 0;
                NextPlayer();
                    }
            string messag = answerResult ? "Correct" : "Incorrect";
            using (var msg = new FrmMessage(messag, value, currentQuestion.CorrectAnswer.ToString()))
            {
                msg.ShowDialog(this);
            }
            ShowTable();
            tblVarAns.Visible = false;
            tblTxtAns.Visible = false;
            tblThemes.Enabled = true;
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            using (var msg = new FrmMessage("Incorrect", 0, currentQuestion.CorrectAnswerTxt.ToString()))
            {
                msg.ShowDialog(this);
            }
            NextPlayer();
            ShowTable();
            tblVarAns.Visible = false;
            tblTxtAns.Visible = false;
            tblThemes.Enabled = true;
            txtBoxTextAns.Text = "";
                        
        }

        private void btnTxtAns_Click(object sender, EventArgs e)
        {

            string box = txtBoxTextAns.Text;
            if (!string.IsNullOrEmpty(box))
            {
                box = box.Trim().ToLowerInvariant();
                int value = currentQuestion?.Value ?? 0;
                string answer = currentQuestion.CorrectAnswerTxt.Trim().ToLowerInvariant();
                if (box == answer)
                {
                    answerResult = true;
                    playerPoints[currentPlayer] += value;
                    NextPlayer();
                }
                else
                {
                    NextPlayer();
                    txtBoxTextAns.Text = "";
                    return;
                }
                string messag = answerResult ? "Correct" : "Incorrect";
                /*MessageBox.Show(msg + Environment.NewLine + $"{value} pts.");*/
                using (var msg = new FrmMessage(messag, value, currentQuestion.CorrectAnswerTxt.ToString()))
                {
                    msg.ShowDialog(this);
                }
                ShowTable();
                tblVarAns.Visible = false;
                tblTxtAns.Visible = false;
                tblThemes.Enabled = true;
                txtBoxTextAns.Text = "";

            }

        }

        private void TopicButton_Click(object sender, EventArgs e)
        {
            tblThemes.Enabled = false;

            if (sender is not Button btn) return;

            // Достаём тему и сложность из Tag
            var (themeIndex, difficulty) = ((int themeIndex, int difficulty))btn.Tag;

            // Берём вопрос
            currentQuestion = Question.Quest(questions, themes[themeIndex], difficulty);

            // Показываем

            OpenQuestion(currentQuestion);
            UpdateQuestionButtons();
        }

        private void OpenQuestion(Question currentQuestion)
        {
            string img = File.Exists(currentQuestion.FilePath) ? currentQuestion.FilePath : "config//logo.png";
            lblQuestion.Text = currentQuestion.Text;
            if (picture.Image != null)
            {
                picture.Image.Dispose();
                picture.Image = null;
            }
            using (var fs = new FileStream(img, FileMode.Open, FileAccess.Read))
            {
                picture.Image = Image.FromStream(fs);
            }
                
            if (currentQuestion.Type == "txt")
            {
                tblTxtAns.Visible = true;
            }
            else
            {
                btnAns1.Text = currentQuestion.Answers[0];
                btnAns2.Text = currentQuestion.Answers[1];
                btnAns3.Text = currentQuestion.Answers[2];
                btnAns4.Text = currentQuestion.Answers[3];
                tblVarAns.Visible = true;
            }
            currentQuestion.Used = true;
            Logger.Log($"{currentQuestion.No} - {currentPlayer} - used");
        }

        private void OpenThemes(string[] themes)
        {
            Label[] lbls = { lblTheme1, lblTheme2, lblTheme3, lblTheme4, lblTheme5, lblTheme6, lblTheme7 };
            Button[] btns = { btn1Easy, btn1Med, btn1Hard, btn2Easy, btn2Med, btn2Hard, btn3Easy, btn3Med, btn3Hard,
                btn4Easy, btn4Med, btn4Hard, btn5Easy, btn5Med, btn5Hard, btn6Easy, btn6Med, btn6Hard, btn7Easy, btn7Med, btn7Hard };
            for (int i = 0; i < themes.Length; i++)
            {
                lbls[i].Text = themes[i];
            }
            for (int i = themes.Length; i < 7; i++)
            {
                lbls[i].Visible = false;
                btns[i * 3].Visible = false;
                btns[i * 3 + 1].Visible = false;
                btns[i * 3 + 2].Visible = false;
            }
        }

        private int[] TableCreate(List<string> playerNames)
        {
            int[] playerPoints = new int[playerNames.Count];
            for (int i = 0; i < playerNames.Count; i++)
            {
                playerPoints[i] = 0;
            }
            return playerPoints;
        }

        private List<Question> qLoad()
        {
            var lines = File.ReadAllLines("res\\qdb.csv").Skip(1);


            foreach (var line in lines)
            {
                var columns = line.Split(';');

                var q = new Question()
                {
                    No = int.Parse(columns[0]),
                    Level = int.Parse(columns[1]),
                    Type = columns[2],
                    Theme = columns[3],
                    Text = columns[4],
                    Answers = new string[] { columns[5], columns[6], columns[7], columns[8] },
                    Hint = columns[9],
                    CorrectAnswer = int.Parse(columns[10]),
                    CorrectAnswerTxt = columns[11],
                    Value = int.Parse(columns[12]),
                    Used = bool.Parse(columns[13]),
                    FilePath = columns[14]
                };
                questions.Add(q);
            }
            return questions;
        }

        private void btnSaveStat_Click(object sender, EventArgs e)
        {
            Logger.LogResult(playerNames, playerPoints);
            UpdateList();
            UpdateFile();
            MessageBox.Show("Success. Udpated");
        }

        
    }
}
