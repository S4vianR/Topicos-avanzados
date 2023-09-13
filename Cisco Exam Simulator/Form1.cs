namespace CCNAv7_Exam
{
    public partial class Form1 : Form
    {
        // Variables
        int score = 0;
        int numQuestions = 0;

        // Constante
        const int NUM_QUESTIONS = 6;

        // Methods
        public void DisplayScore()
        {
            // Mensaje que muestra el puntaje obtenido en español
            MessageBox.Show("Obtuviste " + score + " de " + numQuestions + " preguntas correctas.\nY tu porcentaje fue de: " + CalculatePercentaje(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public double CalculatePercentaje()
        {
            // Aplicar una simple regla de tres para calcular el porcentaje
            double percentaje = (double)score / NUM_QUESTIONS * 100;
            return percentaje;
        }

        public void RestartExam()
        {
            P1RadioB2.Checked = false;
            P1RadioB1.Checked = false;
            P1RadioB3.Checked = false;
            P1RadioB4.Checked = false;
            P1PictureBox.Image = null;
            P1GroupBox.Enabled = true;

            P2CB1.Checked = false;
            P2CB2.Checked = false;
            P2CB3.Checked = false;
            P2CB4.Checked = false;
            P2PictureBox.Image = null;
            P2GroupBox.Enabled = false;

            P3RadioB1.Checked = false;
            P3RadioB2.Checked = false;
            P3RadioB3.Checked = false;
            P3RadioB4.Checked = false;
            P3PictureBox.Image = null;
            P3GroupBox.Enabled = false;

            P4RadioB1.Checked = false;
            P4RadioB2.Checked = false;
            P4RadioB3.Checked = false;
            P4RadioB4.Checked = false;
            P4PictureBox.Image = null;
            P4GroupBox.Enabled = false;

            P5ComboB1.SelectedIndex = -1;
            P5ComboB2.SelectedIndex = -1;
            P5ComboB3.SelectedIndex = -1;
            P5PictureBox.Image = null;
            P5GroupBox.Enabled = false;

            P6TextBox.Clear();
            P6PictureBox.Image = null;
            P6GroupBox.Enabled = false;

            ResetButton.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestartExam();
        }

        private void P1NextButton_Click(object sender, EventArgs e)
        {
            // Verificar si la respuesta es correcta
            if (P1RadioB2.Checked)
            {
                // Aumentar el puntaje
                score++;

                // Establecer la foto del P1PictureBox
                P1PictureBox.Image = Properties.Resources.check_line;
            }
            else
            {
                // Establecer la foto del P1PictureBox
                P1PictureBox.Image = Properties.Resources.close_fill;
            }

            // Aumentar el número de preguntas contestadas
            numQuestions++;
            NumPTExtBox.Text = numQuestions.ToString();

            // Deshabilitar el GroupBox
            P1GroupBox.Enabled = false;

            // Habilitar el GroupBox
            P2GroupBox.Enabled = true;
        }

        private void P2NextButton_Click(object sender, EventArgs e)
        {
            // Verificar si se seleccionaron las respuestas correctas que es el P2B1 y el P2B4
            if (P2CB1.Checked && P2CB4.Checked)
            {
                // Aumentar el puntaje
                score++;

                // Establecer la foto del P2PictureBox
                P2PictureBox.Image = Properties.Resources.check_line;
            }
            else
            {
                // Establecer la foto del P2PictureBox
                P2PictureBox.Image = Properties.Resources.close_fill;
            }

            // Aumentar el número de preguntas contestadas
            numQuestions++;
            NumPTExtBox.Text = numQuestions.ToString();

            // Deshabilitar el GroupBox
            P2GroupBox.Enabled = false;

            // Habilitar el GroupBox
            P3GroupBox.Enabled = true;
        }

        private void P3NextButton_Click(object sender, EventArgs e)
        {
            if (P3RadioB2.Checked)
            {
                // Aumentar el puntaje
                score++;

                // Establecer la foto del P3PictureBox
                P3PictureBox.Image = Properties.Resources.check_line;
            }
            else
            {
                // Establecer la foto del P3PictureBox
                P3PictureBox.Image = Properties.Resources.close_fill;
            }

            // Aumentar el número de preguntas contestadas
            numQuestions++;
            NumPTExtBox.Text = numQuestions.ToString();

            // Deshabilitar el GroupBox
            P3GroupBox.Enabled = false;

            // Habilitar el GroupBox
            P4GroupBox.Enabled = true;
        }

        private void P4NextButton_Click(object sender, EventArgs e)
        {
            if (P4RadioB3.Checked)
            {
                // Aumentar el puntaje
                score++;

                // Establecer la foto del P4PictureBox
                P4PictureBox.Image = Properties.Resources.check_line;
            }
            else
            {
                // Establecer la foto del P4PictureBox
                P4PictureBox.Image = Properties.Resources.close_fill;
            }

            // Aumentar el número de preguntas contestadas
            numQuestions++;
            NumPTExtBox.Text = numQuestions.ToString();

            // Deshabilitar el GroupBox
            P4GroupBox.Enabled = false;

            // Habilitar el GroupBox
            P5GroupBox.Enabled = true;
        }

        private void P5NextButton_Click(object sender, EventArgs e)
        {
            if (P5ComboB1.SelectedIndex == 1 && P5ComboB2.SelectedIndex == 2 && P5ComboB3.SelectedIndex == 1)
            {
                // Aumentar el puntaje
                score++;

                // Establecer la foto del P5PictureBox
                P5PictureBox.Image = Properties.Resources.check_line;
            }
            else
            {
                // Establecer la foto del P5PictureBox
                P5PictureBox.Image = Properties.Resources.close_fill;
            }

            // Aumentar el número de preguntas contestadas
            numQuestions++;
            NumPTExtBox.Text = numQuestions.ToString();

            // Deshabilitar el GroupBox
            P5GroupBox.Enabled = false;

            // Habilitar el GroupBox
            P6GroupBox.Enabled = true;
        }

        private void P6SendButton_Click(object sender, EventArgs e)
        {
            // Verificar si la respuesta es correcta del text box sin importar mayúsculas o minúsculas
            if (P6TextBox.Text.ToLower() == "Certified Cisco Network Associate".ToLower())
            {
                // Aumentar el puntaje
                score++;

                // Establecer la foto del P6PictureBox
                P6PictureBox.Image = Properties.Resources.check_line;
            }
            else
            {
                // Establecer la foto del P6PictureBox
                P6PictureBox.Image = Properties.Resources.close_fill;
            }

            // Aumentar el número de preguntas contestadas
            numQuestions++;
            NumPTExtBox.Text = numQuestions.ToString();

            // Deshabilitar el GroupBox
            P6GroupBox.Enabled = false;


            // Habilitar el boton para reiniciar el examen
            ResetButton.Enabled = true;

            // Mostrar el mensaje con el puntaje obtenido
            DisplayScore();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            RestartExam();
        }
    }
}