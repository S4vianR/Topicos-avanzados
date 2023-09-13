namespace E_PizzaBite
{
    partial class EPizzaBiteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPizzaBiteForm));
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            LargeRadioButton = new RadioButton();
            SmallRadioButton = new RadioButton();
            MediumRadioButton = new RadioButton();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ChooseIngPRadioButton = new RadioButton();
            SpecialsRadioButton = new RadioButton();
            SpecialsLIstBox = new ListBox();
            SpecialsGroupBox = new GroupBox();
            AddSpecialPizzaButton = new Button();
            IngredientsGroupBox = new GroupBox();
            AddIngredientsButton = new Button();
            Chorizo = new CheckBox();
            label4 = new Label();
            GoatCheese = new CheckBox();
            IngredientsListTextBox = new TextBox();
            FreshBasil = new CheckBox();
            CherryTomatoes = new CheckBox();
            Spinach = new CheckBox();
            RedOnion = new CheckBox();
            Pinnaple = new CheckBox();
            Ham = new CheckBox();
            BlackOlives = new CheckBox();
            RedBellPeppers = new CheckBox();
            Mushrooms = new CheckBox();
            Pepperoni = new CheckBox();
            pictureBox2 = new PictureBox();
            PayButton = new Button();
            AddButton = new Button();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            NumPizzasLabel = new Label();
            ResetAppButton = new Button();
            label5 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SpecialsGroupBox.SuspendLayout();
            IngredientsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(284, 19);
            label1.Name = "label1";
            label1.Size = new Size(211, 48);
            label1.TabIndex = 0;
            label1.Text = "E-PizzaBite";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(ChooseIngPRadioButton);
            groupBox1.Controls.Add(SpecialsRadioButton);
            groupBox1.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(34, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(267, 434);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose your pizza";
            // 
            // panel1
            // 
            panel1.Controls.Add(LargeRadioButton);
            panel1.Controls.Add(SmallRadioButton);
            panel1.Controls.Add(MediumRadioButton);
            panel1.Location = new Point(7, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 56);
            panel1.TabIndex = 13;
            // 
            // LargeRadioButton
            // 
            LargeRadioButton.AutoSize = true;
            LargeRadioButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LargeRadioButton.Location = new Point(166, 13);
            LargeRadioButton.Name = "LargeRadioButton";
            LargeRadioButton.Size = new Size(74, 30);
            LargeRadioButton.TabIndex = 6;
            LargeRadioButton.TabStop = true;
            LargeRadioButton.Text = "Large";
            LargeRadioButton.UseVisualStyleBackColor = true;
            LargeRadioButton.CheckedChanged += LargeRadioButton_CheckedChanged;
            // 
            // SmallRadioButton
            // 
            SmallRadioButton.AutoSize = true;
            SmallRadioButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SmallRadioButton.Location = new Point(3, 14);
            SmallRadioButton.Name = "SmallRadioButton";
            SmallRadioButton.Size = new Size(75, 30);
            SmallRadioButton.TabIndex = 4;
            SmallRadioButton.TabStop = true;
            SmallRadioButton.Text = "Small";
            SmallRadioButton.UseVisualStyleBackColor = true;
            SmallRadioButton.CheckedChanged += SmallRadioButton_CheckedChanged;
            // 
            // MediumRadioButton
            // 
            MediumRadioButton.AutoSize = true;
            MediumRadioButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MediumRadioButton.Location = new Point(77, 13);
            MediumRadioButton.Name = "MediumRadioButton";
            MediumRadioButton.Size = new Size(94, 30);
            MediumRadioButton.TabIndex = 5;
            MediumRadioButton.TabStop = true;
            MediumRadioButton.Text = "Medium";
            MediumRadioButton.UseVisualStyleBackColor = true;
            MediumRadioButton.CheckedChanged += MediumRadioButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 98);
            label2.Name = "label2";
            label2.Size = new Size(139, 26);
            label2.TabIndex = 3;
            label2.Text = "Choose your size";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pizza;
            pictureBox1.Location = new Point(17, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ChooseIngPRadioButton
            // 
            ChooseIngPRadioButton.AutoSize = true;
            ChooseIngPRadioButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseIngPRadioButton.Location = new Point(6, 29);
            ChooseIngPRadioButton.Name = "ChooseIngPRadioButton";
            ChooseIngPRadioButton.Size = new Size(181, 30);
            ChooseIngPRadioButton.TabIndex = 1;
            ChooseIngPRadioButton.TabStop = true;
            ChooseIngPRadioButton.Text = "Choose Ingredients";
            ChooseIngPRadioButton.UseVisualStyleBackColor = true;
            ChooseIngPRadioButton.CheckedChanged += ChooseIngPRadioButton_CheckedChanged;
            // 
            // SpecialsRadioButton
            // 
            SpecialsRadioButton.AutoSize = true;
            SpecialsRadioButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SpecialsRadioButton.Location = new Point(6, 65);
            SpecialsRadioButton.Name = "SpecialsRadioButton";
            SpecialsRadioButton.Size = new Size(96, 30);
            SpecialsRadioButton.TabIndex = 0;
            SpecialsRadioButton.TabStop = true;
            SpecialsRadioButton.Text = "Specials";
            SpecialsRadioButton.UseVisualStyleBackColor = true;
            SpecialsRadioButton.CheckedChanged += SpecialsRadioButton_CheckedChanged;
            // 
            // SpecialsLIstBox
            // 
            SpecialsLIstBox.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SpecialsLIstBox.FormattingEnabled = true;
            SpecialsLIstBox.ItemHeight = 26;
            SpecialsLIstBox.Items.AddRange(new object[] { " Carbonara", " Capricciosa", " Margherita", " BBQChicken", " Supreme" });
            SpecialsLIstBox.Location = new Point(6, 29);
            SpecialsLIstBox.Name = "SpecialsLIstBox";
            SpecialsLIstBox.Size = new Size(238, 134);
            SpecialsLIstBox.TabIndex = 0;
            // 
            // SpecialsGroupBox
            // 
            SpecialsGroupBox.Controls.Add(AddSpecialPizzaButton);
            SpecialsGroupBox.Controls.Add(SpecialsLIstBox);
            SpecialsGroupBox.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SpecialsGroupBox.Location = new Point(319, 268);
            SpecialsGroupBox.Name = "SpecialsGroupBox";
            SpecialsGroupBox.Size = new Size(250, 216);
            SpecialsGroupBox.TabIndex = 2;
            SpecialsGroupBox.TabStop = false;
            SpecialsGroupBox.Text = "Specials";
            SpecialsGroupBox.Visible = false;
            // 
            // AddSpecialPizzaButton
            // 
            AddSpecialPizzaButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddSpecialPizzaButton.Location = new Point(79, 174);
            AddSpecialPizzaButton.Name = "AddSpecialPizzaButton";
            AddSpecialPizzaButton.Size = new Size(73, 29);
            AddSpecialPizzaButton.TabIndex = 12;
            AddSpecialPizzaButton.Text = "Submit";
            AddSpecialPizzaButton.UseVisualStyleBackColor = true;
            AddSpecialPizzaButton.Click += AddSpecialPizzaButton_Click;
            // 
            // IngredientsGroupBox
            // 
            IngredientsGroupBox.Controls.Add(AddIngredientsButton);
            IngredientsGroupBox.Controls.Add(Chorizo);
            IngredientsGroupBox.Controls.Add(label4);
            IngredientsGroupBox.Controls.Add(GoatCheese);
            IngredientsGroupBox.Controls.Add(IngredientsListTextBox);
            IngredientsGroupBox.Controls.Add(FreshBasil);
            IngredientsGroupBox.Controls.Add(CherryTomatoes);
            IngredientsGroupBox.Controls.Add(Spinach);
            IngredientsGroupBox.Controls.Add(RedOnion);
            IngredientsGroupBox.Controls.Add(Pinnaple);
            IngredientsGroupBox.Controls.Add(Ham);
            IngredientsGroupBox.Controls.Add(BlackOlives);
            IngredientsGroupBox.Controls.Add(RedBellPeppers);
            IngredientsGroupBox.Controls.Add(Mushrooms);
            IngredientsGroupBox.Controls.Add(Pepperoni);
            IngredientsGroupBox.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            IngredientsGroupBox.Location = new Point(319, 80);
            IngredientsGroupBox.Name = "IngredientsGroupBox";
            IngredientsGroupBox.Size = new Size(610, 145);
            IngredientsGroupBox.TabIndex = 3;
            IngredientsGroupBox.TabStop = false;
            IngredientsGroupBox.Text = "Ingredients";
            // 
            // AddIngredientsButton
            // 
            AddIngredientsButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddIngredientsButton.Location = new Point(399, 110);
            AddIngredientsButton.Name = "AddIngredientsButton";
            AddIngredientsButton.Size = new Size(73, 29);
            AddIngredientsButton.TabIndex = 11;
            AddIngredientsButton.Text = "Submit";
            AddIngredientsButton.UseVisualStyleBackColor = true;
            AddIngredientsButton.Click += AddIngredientsButton_Click;
            // 
            // Chorizo
            // 
            Chorizo.AutoSize = true;
            Chorizo.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Chorizo.Location = new Point(287, 105);
            Chorizo.Name = "Chorizo";
            Chorizo.Size = new Size(93, 30);
            Chorizo.TabIndex = 10;
            Chorizo.Tag = "Chorizo";
            Chorizo.Text = "Chorizo";
            Chorizo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(458, 19);
            label4.Name = "label4";
            label4.Size = new Size(146, 26);
            label4.TabIndex = 14;
            label4.Text = "List of ingredients:";
            // 
            // GoatCheese
            // 
            GoatCheese.AutoSize = true;
            GoatCheese.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GoatCheese.Location = new Point(287, 79);
            GoatCheese.Name = "GoatCheese";
            GoatCheese.Size = new Size(132, 30);
            GoatCheese.TabIndex = 9;
            GoatCheese.Tag = "GoatCheese";
            GoatCheese.Text = "Goat Cheese";
            GoatCheese.UseVisualStyleBackColor = true;
            // 
            // IngredientsListTextBox
            // 
            IngredientsListTextBox.Location = new Point(478, 42);
            IngredientsListTextBox.Multiline = true;
            IngredientsListTextBox.Name = "IngredientsListTextBox";
            IngredientsListTextBox.Size = new Size(102, 103);
            IngredientsListTextBox.TabIndex = 13;
            // 
            // FreshBasil
            // 
            FreshBasil.AutoSize = true;
            FreshBasil.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FreshBasil.Location = new Point(287, 53);
            FreshBasil.Name = "FreshBasil";
            FreshBasil.Size = new Size(114, 30);
            FreshBasil.TabIndex = 8;
            FreshBasil.Tag = "FreshBasil";
            FreshBasil.Text = "Fresh Basil";
            FreshBasil.UseVisualStyleBackColor = true;
            // 
            // CherryTomatoes
            // 
            CherryTomatoes.AutoSize = true;
            CherryTomatoes.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CherryTomatoes.Location = new Point(287, 29);
            CherryTomatoes.Name = "CherryTomatoes";
            CherryTomatoes.Size = new Size(164, 30);
            CherryTomatoes.TabIndex = 7;
            CherryTomatoes.Tag = "CherryTomatoes";
            CherryTomatoes.Text = "Cherry Tomatoes";
            CherryTomatoes.UseVisualStyleBackColor = true;
            // 
            // Spinach
            // 
            Spinach.AutoSize = true;
            Spinach.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Spinach.Location = new Point(167, 79);
            Spinach.Name = "Spinach";
            Spinach.Size = new Size(96, 30);
            Spinach.TabIndex = 6;
            Spinach.Tag = "Spinach";
            Spinach.Text = "Spinach";
            Spinach.UseVisualStyleBackColor = true;
            // 
            // RedOnion
            // 
            RedOnion.AutoSize = true;
            RedOnion.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RedOnion.Location = new Point(167, 105);
            RedOnion.Name = "RedOnion";
            RedOnion.Size = new Size(112, 30);
            RedOnion.TabIndex = 5;
            RedOnion.Tag = "RedOnion";
            RedOnion.Text = "Red Onion";
            RedOnion.UseVisualStyleBackColor = true;
            // 
            // Pinnaple
            // 
            Pinnaple.AutoSize = true;
            Pinnaple.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Pinnaple.Location = new Point(167, 53);
            Pinnaple.Name = "Pinnaple";
            Pinnaple.Size = new Size(109, 30);
            Pinnaple.TabIndex = 4;
            Pinnaple.Tag = "Pineapple";
            Pinnaple.Text = "Pineapple";
            Pinnaple.UseVisualStyleBackColor = true;
            // 
            // Ham
            // 
            Ham.AutoSize = true;
            Ham.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Ham.Location = new Point(167, 29);
            Ham.Name = "Ham";
            Ham.Size = new Size(69, 30);
            Ham.TabIndex = 4;
            Ham.Tag = "Ham";
            Ham.Text = "Ham";
            Ham.UseVisualStyleBackColor = true;
            // 
            // BlackOlives
            // 
            BlackOlives.AutoSize = true;
            BlackOlives.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BlackOlives.Location = new Point(6, 105);
            BlackOlives.Name = "BlackOlives";
            BlackOlives.Size = new Size(123, 30);
            BlackOlives.TabIndex = 3;
            BlackOlives.Tag = "BlackOlives";
            BlackOlives.Text = "Black Olives";
            BlackOlives.UseVisualStyleBackColor = true;
            // 
            // RedBellPeppers
            // 
            RedBellPeppers.AutoSize = true;
            RedBellPeppers.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RedBellPeppers.Location = new Point(6, 79);
            RedBellPeppers.Name = "RedBellPeppers";
            RedBellPeppers.Size = new Size(157, 30);
            RedBellPeppers.TabIndex = 2;
            RedBellPeppers.Tag = "RedBellPeppers";
            RedBellPeppers.Text = "Red Bell Peppers";
            RedBellPeppers.UseVisualStyleBackColor = true;
            // 
            // Mushrooms
            // 
            Mushrooms.AutoSize = true;
            Mushrooms.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Mushrooms.Location = new Point(6, 53);
            Mushrooms.Name = "Mushrooms";
            Mushrooms.Size = new Size(124, 30);
            Mushrooms.TabIndex = 1;
            Mushrooms.Tag = "Mushrooms";
            Mushrooms.Text = "Mushrooms";
            Mushrooms.UseVisualStyleBackColor = true;
            // 
            // Pepperoni
            // 
            Pepperoni.AutoSize = true;
            Pepperoni.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Pepperoni.Location = new Point(6, 29);
            Pepperoni.Name = "Pepperoni";
            Pepperoni.Size = new Size(111, 30);
            Pepperoni.TabIndex = 0;
            Pepperoni.Tag = "Pepperoni";
            Pepperoni.Text = "Pepperoni";
            Pepperoni.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._7183811;
            pictureBox2.Location = new Point(486, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // PayButton
            // 
            PayButton.Enabled = false;
            PayButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PayButton.Location = new Point(757, 442);
            PayButton.Name = "PayButton";
            PayButton.Size = new Size(94, 29);
            PayButton.TabIndex = 5;
            PayButton.Text = "Pay";
            PayButton.UseVisualStyleBackColor = true;
            PayButton.Click += PayButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(625, 442);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(113, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.precios;
            pictureBox3.Location = new Point(3, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(344, 128);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(579, 268);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 157);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Precios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 36);
            label3.Name = "label3";
            label3.Size = new Size(145, 26);
            label3.TabIndex = 9;
            label3.Text = "Number of pizzas:";
            // 
            // NumPizzasLabel
            // 
            NumPizzasLabel.AutoSize = true;
            NumPizzasLabel.BorderStyle = BorderStyle.FixedSingle;
            NumPizzasLabel.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NumPizzasLabel.Location = new Point(171, 36);
            NumPizzasLabel.Name = "NumPizzasLabel";
            NumPizzasLabel.Size = new Size(23, 28);
            NumPizzasLabel.TabIndex = 12;
            NumPizzasLabel.Text = "0";
            // 
            // ResetAppButton
            // 
            ResetAppButton.Location = new Point(757, 483);
            ResetAppButton.Name = "ResetAppButton";
            ResetAppButton.Size = new Size(94, 29);
            ResetAppButton.TabIndex = 15;
            ResetAppButton.Text = "Reset app";
            ResetAppButton.UseVisualStyleBackColor = true;
            ResetAppButton.Click += ResetAppButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 487);
            label5.Name = "label5";
            label5.Size = new Size(241, 20);
            label5.TabIndex = 16;
            label5.Text = "In case of an error or bug push this:";
            // 
            // EPizzaBiteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 92, 104);
            ClientSize = new Size(938, 516);
            Controls.Add(label5);
            Controls.Add(ResetAppButton);
            Controls.Add(NumPizzasLabel);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(AddButton);
            Controls.Add(PayButton);
            Controls.Add(pictureBox2);
            Controls.Add(IngredientsGroupBox);
            Controls.Add(SpecialsGroupBox);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EPizzaBiteForm";
            Text = "Form1";
            Load += EPizzaBiteForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SpecialsGroupBox.ResumeLayout(false);
            IngredientsGroupBox.ResumeLayout(false);
            IngredientsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ListBox SpecialsLIstBox;
        private GroupBox SpecialsGroupBox;
        private GroupBox IngredientsGroupBox;
        private CheckBox CherryTomatoes;
        private CheckBox Spinach;
        private CheckBox RedOnion;
        private CheckBox Pinnaple;
        private CheckBox Ham;
        private CheckBox BlackOlives;
        private CheckBox RedBellPeppers;
        private CheckBox Mushrooms;
        private CheckBox Pepperoni;
        private CheckBox Chorizo;
        private CheckBox GoatCheese;
        private CheckBox FreshBasil;
        private PictureBox pictureBox1;
        private RadioButton ChooseIngPRadioButton;
        private RadioButton SpecialsRadioButton;
        private RadioButton LargeRadioButton;
        private RadioButton MediumRadioButton;
        private RadioButton SmallRadioButton;
        private Label label2;
        private PictureBox pictureBox2;
        private Button PayButton;
        private Button AddButton;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private Label label3;
        private Label NumPizzasLabel;
        private Panel panel1;
        private TextBox IngredientsListTextBox;
        private Label label4;
        private Button AddIngredientsButton;
        private Button AddSpecialPizzaButton;
        private Button ResetAppButton;
        private Label label5;
    }
}