namespace RekenTrainer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpBoxMultiply = new GroupBox();
            chkBoxMulitply = new CheckedListBox();
            btnCreate = new Button();
            lstBoxExercises = new ListBox();
            grpBoxExercise = new GroupBox();
            txtAnswer = new TextBox();
            lblCurrentExercise = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            grpBoxMultiply.SuspendLayout();
            grpBoxExercise.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxMultiply
            // 
            grpBoxMultiply.Controls.Add(chkBoxMulitply);
            grpBoxMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBoxMultiply.Location = new Point(12, 12);
            grpBoxMultiply.Name = "grpBoxMultiply";
            grpBoxMultiply.Size = new Size(102, 296);
            grpBoxMultiply.TabIndex = 0;
            grpBoxMultiply.TabStop = false;
            grpBoxMultiply.Text = "Maaltafels";
            // 
            // chkBoxMulitply
            // 
            chkBoxMulitply.BackColor = SystemColors.Control;
            chkBoxMulitply.BorderStyle = BorderStyle.None;
            chkBoxMulitply.CheckOnClick = true;
            chkBoxMulitply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBoxMulitply.FormattingEnabled = true;
            chkBoxMulitply.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            chkBoxMulitply.Location = new Point(6, 26);
            chkBoxMulitply.Name = "chkBoxMulitply";
            chkBoxMulitply.Size = new Size(75, 264);
            chkBoxMulitply.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Transparent;
            btnCreate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(12, 314);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(102, 48);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Maak!";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lstBoxExercises
            // 
            lstBoxExercises.FormattingEnabled = true;
            lstBoxExercises.ItemHeight = 21;
            lstBoxExercises.Location = new Point(6, 73);
            lstBoxExercises.Name = "lstBoxExercises";
            lstBoxExercises.Size = new Size(173, 277);
            lstBoxExercises.TabIndex = 4;
            // 
            // grpBoxExercise
            // 
            grpBoxExercise.Controls.Add(txtAnswer);
            grpBoxExercise.Controls.Add(lblCurrentExercise);
            grpBoxExercise.Controls.Add(lstBoxExercises);
            grpBoxExercise.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpBoxExercise.Location = new Point(120, 12);
            grpBoxExercise.Name = "grpBoxExercise";
            grpBoxExercise.Size = new Size(185, 356);
            grpBoxExercise.TabIndex = 5;
            grpBoxExercise.TabStop = false;
            grpBoxExercise.Text = "Oefeningen";
            grpBoxExercise.Enter += grpBoxExercise_Enter;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = SystemColors.ControlLight;
            txtAnswer.BorderStyle = BorderStyle.None;
            txtAnswer.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnswer.Location = new Point(120, 23);
            txtAnswer.Multiline = true;
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(59, 44);
            txtAnswer.TabIndex = 6;
            txtAnswer.TextAlign = HorizontalAlignment.Center;
            txtAnswer.TextChanged += txtAnswer_TextChanged;
            txtAnswer.KeyDown += txtAnswer_KeyDown;
            // 
            // lblCurrentExercise
            // 
            lblCurrentExercise.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentExercise.Location = new Point(6, 23);
            lblCurrentExercise.Name = "lblCurrentExercise";
            lblCurrentExercise.Size = new Size(95, 44);
            lblCurrentExercise.TabIndex = 5;
            lblCurrentExercise.Text = "(empty)";
            lblCurrentExercise.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 388);
            Controls.Add(grpBoxExercise);
            Controls.Add(btnCreate);
            Controls.Add(grpBoxMultiply);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Oefeningen";
            grpBoxMultiply.ResumeLayout(false);
            grpBoxExercise.ResumeLayout(false);
            grpBoxExercise.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxMultiply;
        private Button btnCreate;
        private CheckedListBox chkBoxMulitply;
        private ListBox lstBoxExercises;
        private GroupBox grpBoxExercise;
        private System.Windows.Forms.Timer timer1;
        private Label lblCurrentExercise;
        private TextBox txtAnswer;
    }
}
