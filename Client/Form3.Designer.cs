namespace Client
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            groupBox1 = new GroupBox();
            radioCargo = new RadioButton();
            radioPas = new RadioButton();
            groupBox2 = new GroupBox();
            percentLoad = new Label();
            label1 = new Label();
            trackCarPer = new TrackBar();
            comboResourceType = new ComboBox();
            buttonCreateWagon = new Guna.UI2.WinForms.Guna2Button();
            buttonLoadWagon = new Guna.UI2.WinForms.Guna2Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackCarPer).BeginInit();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.CustomizableEdges = customizableEdges5;
            guna2ControlBox1.FillColor = Color.FromArgb(139, 152, 166);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(567, -1);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioCargo);
            groupBox1.Controls.Add(radioPas);
            groupBox1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 430);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание";
            // 
            // radioCargo
            // 
            radioCargo.AutoSize = true;
            radioCargo.Location = new Point(6, 77);
            radioCargo.Name = "radioCargo";
            radioCargo.Size = new Size(168, 26);
            radioCargo.TabIndex = 1;
            radioCargo.TabStop = true;
            radioCargo.Text = "Грузовой вагон";
            radioCargo.UseVisualStyleBackColor = true;
            // 
            // radioPas
            // 
            radioPas.AutoSize = true;
            radioPas.Location = new Point(6, 45);
            radioPas.Name = "radioPas";
            radioPas.Size = new Size(208, 26);
            radioPas.TabIndex = 0;
            radioPas.TabStop = true;
            radioPas.Text = "Пассажирский вагон";
            radioPas.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(percentLoad);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(trackCarPer);
            groupBox2.Controls.Add(comboResourceType);
            groupBox2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(315, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 430);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Загрузка";
            // 
            // percentLoad
            // 
            percentLoad.AutoSize = true;
            percentLoad.Location = new Point(25, 173);
            percentLoad.Name = "percentLoad";
            percentLoad.Size = new Size(20, 22);
            percentLoad.TabIndex = 7;
            percentLoad.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 91);
            label1.Name = "label1";
            label1.Size = new Size(240, 22);
            label1.TabIndex = 4;
            label1.Text = "Процент загрузки вагона";
            // 
            // trackCarPer
            // 
            trackCarPer.Location = new Point(15, 125);
            trackCarPer.Maximum = 100;
            trackCarPer.Name = "trackCarPer";
            trackCarPer.Size = new Size(264, 45);
            trackCarPer.TabIndex = 3;
            trackCarPer.Scroll += trackCarPer_Scroll;
            // 
            // comboResourceType
            // 
            comboResourceType.FormattingEnabled = true;
            comboResourceType.Items.AddRange(new object[] { "Пустой грузовой", "Уголь", "Дерево", "Сельхозтехника", "Топливо", "Животные" });
            comboResourceType.Location = new Point(15, 44);
            comboResourceType.Name = "comboResourceType";
            comboResourceType.Size = new Size(264, 30);
            comboResourceType.TabIndex = 0;
            // 
            // buttonCreateWagon
            // 
            buttonCreateWagon.CustomizableEdges = customizableEdges3;
            buttonCreateWagon.DisabledState.BorderColor = Color.DarkGray;
            buttonCreateWagon.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonCreateWagon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonCreateWagon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonCreateWagon.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreateWagon.ForeColor = Color.White;
            buttonCreateWagon.Location = new Point(12, 475);
            buttonCreateWagon.Name = "buttonCreateWagon";
            buttonCreateWagon.ShadowDecoration.CustomizableEdges = customizableEdges4;
            buttonCreateWagon.Size = new Size(285, 45);
            buttonCreateWagon.TabIndex = 3;
            buttonCreateWagon.Text = "Добавить новый вагон";
            buttonCreateWagon.Click += buttonCreateWagon_Click;
            // 
            // buttonLoadWagon
            // 
            buttonLoadWagon.CustomizableEdges = customizableEdges1;
            buttonLoadWagon.DisabledState.BorderColor = Color.DarkGray;
            buttonLoadWagon.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonLoadWagon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonLoadWagon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonLoadWagon.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLoadWagon.ForeColor = Color.White;
            buttonLoadWagon.Location = new Point(315, 475);
            buttonLoadWagon.Name = "buttonLoadWagon";
            buttonLoadWagon.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buttonLoadWagon.Size = new Size(285, 45);
            buttonLoadWagon.TabIndex = 4;
            buttonLoadWagon.Text = "Загрузить существующий вагон";
            buttonLoadWagon.Click += buttonLoadWagon_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(610, 528);
            Controls.Add(buttonLoadWagon);
            Controls.Add(buttonCreateWagon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(guna2ControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackCarPer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button buttonLoadWagon;
        private Guna.UI2.WinForms.Guna2Button buttonCreateWagon;
        private ComboBox comboResourceType;
        private Label label1;
        private TrackBar trackCarPer;
        private Label percentLoad;
        private RadioButton radioCargo;
        private RadioButton radioPas;
    }
}