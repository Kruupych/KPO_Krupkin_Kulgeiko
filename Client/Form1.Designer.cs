namespace Client
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            textMain = new RichTextBox();
            labelName = new Label();
            comboTrains = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboWagons = new ComboBox();
            buttonGetTrain = new Guna.UI2.WinForms.Guna2GradientButton();
            buttonSendTrain = new Guna.UI2.WinForms.Guna2GradientButton();
            butttonAddW = new Guna.UI2.WinForms.Guna2Button();
            buttonDelW = new Guna.UI2.WinForms.Guna2Button();
            buttonClearW = new Guna.UI2.WinForms.Guna2Button();
            buttonLoadW = new Guna.UI2.WinForms.Guna2Button();
            TimeNow = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            comboFreeWagons = new ComboBox();
            label3 = new Label();
            label4 = new Label();
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
            guna2ControlBox1.CustomizableEdges = customizableEdges13;
            guna2ControlBox1.FillColor = Color.Red;
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(1156, -1);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2ControlBox1.Size = new Size(45, 29);
            guna2ControlBox1.TabIndex = 1;
            // 
            // textMain
            // 
            textMain.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textMain.Location = new Point(868, 34);
            textMain.Name = "textMain";
            textMain.Size = new Size(320, 554);
            textMain.TabIndex = 3;
            textMain.Text = "";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(503, 4);
            labelName.Name = "labelName";
            labelName.Size = new Size(70, 24);
            labelName.TabIndex = 4;
            labelName.Text = "Нигде";
            // 
            // comboTrains
            // 
            comboTrains.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboTrains.FormattingEnabled = true;
            comboTrains.Location = new Point(12, 44);
            comboTrains.Name = "comboTrains";
            comboTrains.Size = new Size(196, 30);
            comboTrains.TabIndex = 5;
            comboTrains.Click += comboTrains_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 12);
            label1.Name = "label1";
            label1.Size = new Size(190, 24);
            label1.TabIndex = 7;
            label1.Text = "Выберите поезд:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(190, 24);
            label2.TabIndex = 8;
            label2.Text = "Выберите вагон:";
            // 
            // comboWagons
            // 
            comboWagons.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboWagons.FormattingEnabled = true;
            comboWagons.Location = new Point(12, 154);
            comboWagons.Name = "comboWagons";
            comboWagons.Size = new Size(196, 30);
            comboWagons.TabIndex = 9;
            // 
            // buttonGetTrain
            // 
            buttonGetTrain.CustomizableEdges = customizableEdges11;
            buttonGetTrain.DisabledState.BorderColor = Color.DarkGray;
            buttonGetTrain.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonGetTrain.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonGetTrain.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            buttonGetTrain.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonGetTrain.FillColor = Color.FromArgb(255, 192, 128);
            buttonGetTrain.FillColor2 = Color.Red;
            buttonGetTrain.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGetTrain.ForeColor = Color.White;
            buttonGetTrain.Location = new Point(272, 543);
            buttonGetTrain.Name = "buttonGetTrain";
            buttonGetTrain.ShadowDecoration.CustomizableEdges = customizableEdges12;
            buttonGetTrain.Size = new Size(180, 45);
            buttonGetTrain.TabIndex = 10;
            buttonGetTrain.Text = "Поезд прибыл";
            buttonGetTrain.Click += buttonGetTrain_Click;
            // 
            // buttonSendTrain
            // 
            buttonSendTrain.CustomizableEdges = customizableEdges9;
            buttonSendTrain.DisabledState.BorderColor = Color.DarkGray;
            buttonSendTrain.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonSendTrain.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonSendTrain.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            buttonSendTrain.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonSendTrain.FillColor = Color.Red;
            buttonSendTrain.FillColor2 = Color.FromArgb(255, 192, 128);
            buttonSendTrain.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSendTrain.ForeColor = Color.White;
            buttonSendTrain.Location = new Point(472, 543);
            buttonSendTrain.Name = "buttonSendTrain";
            buttonSendTrain.ShadowDecoration.CustomizableEdges = customizableEdges10;
            buttonSendTrain.Size = new Size(180, 45);
            buttonSendTrain.TabIndex = 11;
            buttonSendTrain.Text = "Поезд отправился";
            buttonSendTrain.Click += buttonSendTrain_Click;
            // 
            // butttonAddW
            // 
            butttonAddW.CustomizableEdges = customizableEdges7;
            butttonAddW.DisabledState.BorderColor = Color.DarkGray;
            butttonAddW.DisabledState.CustomBorderColor = Color.DarkGray;
            butttonAddW.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            butttonAddW.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            butttonAddW.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            butttonAddW.ForeColor = Color.White;
            butttonAddW.Location = new Point(15, 208);
            butttonAddW.Name = "butttonAddW";
            butttonAddW.ShadowDecoration.CustomizableEdges = customizableEdges8;
            butttonAddW.Size = new Size(180, 45);
            butttonAddW.TabIndex = 12;
            butttonAddW.Text = "Добавить вагон";
            butttonAddW.Click += butttonAddW_Click;
            // 
            // buttonDelW
            // 
            buttonDelW.CustomizableEdges = customizableEdges5;
            buttonDelW.DisabledState.BorderColor = Color.DarkGray;
            buttonDelW.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonDelW.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonDelW.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonDelW.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelW.ForeColor = Color.White;
            buttonDelW.Location = new Point(201, 208);
            buttonDelW.Name = "buttonDelW";
            buttonDelW.ShadowDecoration.CustomizableEdges = customizableEdges6;
            buttonDelW.Size = new Size(180, 45);
            buttonDelW.TabIndex = 13;
            buttonDelW.Text = "Удалить вагон";
            // 
            // buttonClearW
            // 
            buttonClearW.CustomizableEdges = customizableEdges1;
            buttonClearW.DisabledState.BorderColor = Color.DarkGray;
            buttonClearW.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonClearW.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonClearW.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonClearW.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClearW.ForeColor = Color.White;
            buttonClearW.Location = new Point(201, 259);
            buttonClearW.Name = "buttonClearW";
            buttonClearW.ShadowDecoration.CustomizableEdges = customizableEdges2;
            buttonClearW.Size = new Size(180, 45);
            buttonClearW.TabIndex = 15;
            buttonClearW.Text = "Разгрузить вагон";
            buttonClearW.Click += buttonClearW_Click;
            // 
            // buttonLoadW
            // 
            buttonLoadW.CustomizableEdges = customizableEdges3;
            buttonLoadW.DisabledState.BorderColor = Color.DarkGray;
            buttonLoadW.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonLoadW.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonLoadW.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonLoadW.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLoadW.ForeColor = Color.White;
            buttonLoadW.Location = new Point(15, 259);
            buttonLoadW.Name = "buttonLoadW";
            buttonLoadW.ShadowDecoration.CustomizableEdges = customizableEdges4;
            buttonLoadW.Size = new Size(180, 45);
            buttonLoadW.TabIndex = 14;
            buttonLoadW.Text = "Загрузить вагон";
            buttonLoadW.Click += butttonAddW_Click;
            // 
            // TimeNow
            // 
            TimeNow.AutoSize = true;
            TimeNow.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TimeNow.Location = new Point(582, 4);
            TimeNow.Name = "TimeNow";
            TimeNow.Size = new Size(0, 24);
            TimeNow.TabIndex = 16;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 500;
            timer2.Tick += timer2_Tick;
            // 
            // comboFreeWagons
            // 
            comboFreeWagons.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboFreeWagons.FormattingEnabled = true;
            comboFreeWagons.Location = new Point(316, 154);
            comboFreeWagons.Name = "comboFreeWagons";
            comboFreeWagons.Size = new Size(196, 30);
            comboFreeWagons.TabIndex = 17;
            comboFreeWagons.SelectedIndexChanged += comboFreeWagons_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 18;
            label3.Text = "Вагоны поезда";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(316, 127);
            label4.Name = "label4";
            label4.Size = new Size(202, 24);
            label4.TabIndex = 19;
            label4.Text = "Свободные вагоны";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1200, 600);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboFreeWagons);
            Controls.Add(TimeNow);
            Controls.Add(buttonClearW);
            Controls.Add(buttonLoadW);
            Controls.Add(buttonDelW);
            Controls.Add(butttonAddW);
            Controls.Add(buttonSendTrain);
            Controls.Add(buttonGetTrain);
            Controls.Add(comboWagons);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboTrains);
            Controls.Add(labelName);
            Controls.Add(textMain);
            Controls.Add(guna2ControlBox1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private RichTextBox textMain;
        private Label label2;
        private Label label1;
        private ComboBox comboTrains;
        private Label labelName;
        private ComboBox comboWagons;
        private Guna.UI2.WinForms.Guna2GradientButton buttonSendTrain;
        private Guna.UI2.WinForms.Guna2GradientButton buttonGetTrain;
        private Guna.UI2.WinForms.Guna2Button butttonAddW;
        private Guna.UI2.WinForms.Guna2Button buttonClearW;
        private Guna.UI2.WinForms.Guna2Button buttonLoadW;
        private Guna.UI2.WinForms.Guna2Button buttonDelW;
        private Label TimeNow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label4;
        private Label label3;
        private ComboBox comboFreeWagons;
    }
}
