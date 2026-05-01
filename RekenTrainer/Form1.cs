using System.Drawing.Text;

namespace RekenTrainer
{
    public partial class Form1 : Form
    {
        // 🔹 Deze drie velden worden door ALLE methodes gebruikt
        private List<string> multiplyExercises;
        private List<int> multiplySolutions;
        private int currentIndex = 0;
        private int score = 0;
        private System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            multiplyExercises = new List<string>();
            multiplySolutions = new List<int>();
            currentIndex = 0;

            List<int> multiplyCheck = new List<int>();
            Random rnd = new Random();

            string input = InputBox("Aantal oefeningen", "Hoeveel oefeningen wil je maken?");
            if (!int.TryParse(input, out int aantalOefeningen) || aantalOefeningen <= 0)
            {
                MessageBox.Show("Gelieve een geldig getal in te voeren.");
                return;
            }

            foreach (string item in chkBoxMulitply.CheckedItems)
            {
                if (int.TryParse(item, out int tafel))
                    multiplyCheck.Add(tafel);
            }

            for (int i = 0; i < aantalOefeningen; i++)
            {
                int num = rnd.Next(0, 11); // 0 t/m 10
                int tafel = multiplyCheck[rnd.Next(multiplyCheck.Count)];

                multiplyExercises.Add($"{num} x {tafel}");
                multiplySolutions.Add(num * tafel);
            }

            lstBoxExercises.Font = new Font("Consolas", 10);
            lstBoxExercises.Items.Clear();
            stopwatch.Reset();
            stopwatch.Start();
            ToonVolgendeOefening();
        }

        private void ToonVolgendeOefening()
        {
            if (currentIndex >= multiplyExercises.Count)
            {
                stopwatch.Stop();

                lblCurrentExercise.Text = "Klaar!";
                txtAnswer.Enabled = false;

                TimeSpan tijd = stopwatch.Elapsed;

                MessageBox.Show(
                    $"Je score: {score} op {multiplyExercises.Count}\n" +
                    $"Tijd: {tijd.Minutes:D2}:{tijd.Seconds:D2}",
                    "Resultaat",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }
            lblCurrentExercise.Text = multiplyExercises[currentIndex] + " = ?";
            txtAnswer.Text = "";
            txtAnswer.Enabled = true;
            txtAnswer.Focus();
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ControleerAntwoord();
                e.SuppressKeyPress = true; // voorkomt beep
            }
        }

        private void ControleerAntwoord()
        {
            if (!int.TryParse(txtAnswer.Text, out int antwoord))
                return;

            string oef = multiplyExercises[currentIndex];
            int oplossing = multiplySolutions[currentIndex];

            bool juist = antwoord == oplossing;
            string resultaat = juist ? "✔" : "✖";

            if (juist) score++;

            string formatted = $"{oef} = {antwoord} \t {resultaat}";
            lstBoxExercises.Items.Insert(0, formatted);

            currentIndex++;
            ToonVolgendeOefening();
        }

        private string InputBox(string title, string prompt)
        {
            Form promptForm = new Form()
            {
                Width = 350,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Text = prompt,
                Width = 300,
                Height = 30,
                Font = new Font("Segoe UI", 14, FontStyle.Regular) // 22pt
            };

            TextBox inputBox = new TextBox()
            {
                Left = 20,
                Top = 60,
                Width = 300,
                Font = new Font("Segoe UI", 14, FontStyle.Regular) // 22pt
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 230,
                Width = 90,
                Top = 100,
                Height = 50,
                DialogResult = DialogResult.OK,
                Font = new Font("Segoe UI", 14, FontStyle.Bold) // optioneel groter
            };

            promptForm.Controls.Add(textLabel);
            promptForm.Controls.Add(inputBox);
            promptForm.Controls.Add(confirmation);
            promptForm.AcceptButton = confirmation;

            return promptForm.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpBoxExercise_Enter(object sender, EventArgs e)
        {

        }
    }
}
