namespace Server
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("В пути", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ст. Барановичи", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Пассажирский поезд 10", "train_48.png");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Грузовой поезд 12");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Пассажирский поезд 2");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lvTrainsOutOfDepo = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader("train_48.png");
            this.tbMainPanelTrainInfo = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tbLogs = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPageBuild = new System.Windows.Forms.TabPage();
            this.lbTrainsInDepo = new MaterialSkin.Controls.MaterialListBox();
            this.cardTrainConstruction = new MaterialSkin.Controls.MaterialCard();
            this.sliderWagonsFillness = new MaterialSkin.Controls.MaterialSlider();
            this.btCreateTrain = new MaterialSkin.Controls.MaterialButton();
            this.cbCargoType = new MaterialSkin.Controls.MaterialComboBox();
            this.switchIsPassengerTrain = new MaterialSkin.Controls.MaterialSwitch();
            this.tbWagonsCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.tbTrainPower = new MaterialSkin.Controls.MaterialTextBox2();
            this.btGenerateTrainParams = new MaterialSkin.Controls.MaterialButton();
            this.switchRandomConstructor = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tbTrainName = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btDeleteTrain = new MaterialSkin.Controls.MaterialButton();
            this.btAddTrain = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbConstructPanelTrainInfo = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.iconsImageList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.tabPageBuild.SuspendLayout();
            this.cardTrainConstruction.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageHome);
            this.materialTabControl1.Controls.Add(this.tabPageBuild);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.iconsImageList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1069, 633);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.materialCard3);
            this.tabPageHome.Controls.Add(this.materialCard2);
            this.tabPageHome.ImageKey = "garage_home_48.png";
            this.tabPageHome.Location = new System.Drawing.Point(4, 39);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(1061, 590);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Основная";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel6);
            this.materialCard3.Controls.Add(this.lvTrainsOutOfDepo);
            this.materialCard3.Controls.Add(this.tbMainPanelTrainInfo);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(501, 10);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(507, 570);
            this.materialCard3.TabIndex = 12;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(11, 14);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(158, 24);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Поезда вне депо";
            // 
            // lvTrainsOutOfDepo
            // 
            this.lvTrainsOutOfDepo.AutoArrange = false;
            this.lvTrainsOutOfDepo.AutoSizeTable = false;
            this.lvTrainsOutOfDepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lvTrainsOutOfDepo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvTrainsOutOfDepo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvTrainsOutOfDepo.Depth = 0;
            this.lvTrainsOutOfDepo.FullRowSelect = true;
            listViewGroup1.Header = "В пути";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ст. Барановичи";
            listViewGroup2.Name = "listViewGroup2";
            this.lvTrainsOutOfDepo.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvTrainsOutOfDepo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup2;
            this.lvTrainsOutOfDepo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvTrainsOutOfDepo.Location = new System.Drawing.Point(11, 41);
            this.lvTrainsOutOfDepo.MinimumSize = new System.Drawing.Size(200, 100);
            this.lvTrainsOutOfDepo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvTrainsOutOfDepo.MouseState = MaterialSkin.MouseState.OUT;
            this.lvTrainsOutOfDepo.MultiSelect = false;
            this.lvTrainsOutOfDepo.Name = "lvTrainsOutOfDepo";
            this.lvTrainsOutOfDepo.OwnerDraw = true;
            this.lvTrainsOutOfDepo.Size = new System.Drawing.Size(485, 418);
            this.lvTrainsOutOfDepo.TabIndex = 7;
            this.lvTrainsOutOfDepo.UseCompatibleStateImageBehavior = false;
            this.lvTrainsOutOfDepo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Поезда вне депо";
            this.columnHeader1.Width = 480;
            // 
            // tbMainPanelTrainInfo
            // 
            this.tbMainPanelTrainInfo.AnimateReadOnly = false;
            this.tbMainPanelTrainInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbMainPanelTrainInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbMainPanelTrainInfo.Depth = 0;
            this.tbMainPanelTrainInfo.HideSelection = true;
            this.tbMainPanelTrainInfo.Hint = "Информация о поезде";
            this.tbMainPanelTrainInfo.Location = new System.Drawing.Point(10, 465);
            this.tbMainPanelTrainInfo.MaxLength = 32767;
            this.tbMainPanelTrainInfo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMainPanelTrainInfo.Name = "tbMainPanelTrainInfo";
            this.tbMainPanelTrainInfo.PasswordChar = '\0';
            this.tbMainPanelTrainInfo.ReadOnly = true;
            this.tbMainPanelTrainInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMainPanelTrainInfo.SelectedText = "";
            this.tbMainPanelTrainInfo.SelectionLength = 0;
            this.tbMainPanelTrainInfo.SelectionStart = 0;
            this.tbMainPanelTrainInfo.ShortcutsEnabled = true;
            this.tbMainPanelTrainInfo.Size = new System.Drawing.Size(486, 100);
            this.tbMainPanelTrainInfo.TabIndex = 10;
            this.tbMainPanelTrainInfo.TabStop = false;
            this.tbMainPanelTrainInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMainPanelTrainInfo.UseSystemPasswordChar = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tbLogs);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(10, 10);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(485, 570);
            this.materialCard2.TabIndex = 11;
            // 
            // tbLogs
            // 
            this.tbLogs.AnimateReadOnly = false;
            this.tbLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbLogs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbLogs.Depth = 0;
            this.tbLogs.HideSelection = true;
            this.tbLogs.Location = new System.Drawing.Point(10, 41);
            this.tbLogs.MaxLength = 32767;
            this.tbLogs.MouseState = MaterialSkin.MouseState.OUT;
            this.tbLogs.Name = "tbLogs";
            this.tbLogs.PasswordChar = '\0';
            this.tbLogs.ReadOnly = true;
            this.tbLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogs.SelectedText = "";
            this.tbLogs.SelectionLength = 0;
            this.tbLogs.SelectionStart = 0;
            this.tbLogs.ShortcutsEnabled = true;
            this.tbLogs.Size = new System.Drawing.Size(464, 524);
            this.tbLogs.TabIndex = 8;
            this.tbLogs.TabStop = false;
            this.tbLogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLogs.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(10, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(84, 24);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "События";
            // 
            // tabPageBuild
            // 
            this.tabPageBuild.Controls.Add(this.lbTrainsInDepo);
            this.tabPageBuild.Controls.Add(this.cardTrainConstruction);
            this.tabPageBuild.Controls.Add(this.materialCard1);
            this.tabPageBuild.Controls.Add(this.materialButton1);
            this.tabPageBuild.Controls.Add(this.materialLabel2);
            this.tabPageBuild.Controls.Add(this.materialLabel1);
            this.tabPageBuild.Controls.Add(this.tbConstructPanelTrainInfo);
            this.tabPageBuild.ImageKey = "build_48.png";
            this.tabPageBuild.Location = new System.Drawing.Point(4, 39);
            this.tabPageBuild.Name = "tabPageBuild";
            this.tabPageBuild.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuild.Size = new System.Drawing.Size(1061, 590);
            this.tabPageBuild.TabIndex = 1;
            this.tabPageBuild.Text = "Конструкторская";
            this.tabPageBuild.UseVisualStyleBackColor = true;
            // 
            // lbTrainsInDepo
            // 
            this.lbTrainsInDepo.BackColor = System.Drawing.Color.White;
            this.lbTrainsInDepo.BorderColor = System.Drawing.Color.LightGray;
            this.lbTrainsInDepo.Depth = 0;
            this.lbTrainsInDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbTrainsInDepo.Location = new System.Drawing.Point(6, 45);
            this.lbTrainsInDepo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbTrainsInDepo.Name = "lbTrainsInDepo";
            this.lbTrainsInDepo.SelectedIndex = -1;
            this.lbTrainsInDepo.SelectedItem = null;
            this.lbTrainsInDepo.Size = new System.Drawing.Size(415, 531);
            this.lbTrainsInDepo.TabIndex = 11;
            // 
            // cardTrainConstruction
            // 
            this.cardTrainConstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardTrainConstruction.Controls.Add(this.sliderWagonsFillness);
            this.cardTrainConstruction.Controls.Add(this.btCreateTrain);
            this.cardTrainConstruction.Controls.Add(this.cbCargoType);
            this.cardTrainConstruction.Controls.Add(this.switchIsPassengerTrain);
            this.cardTrainConstruction.Controls.Add(this.tbWagonsCount);
            this.cardTrainConstruction.Controls.Add(this.tbTrainPower);
            this.cardTrainConstruction.Controls.Add(this.btGenerateTrainParams);
            this.cardTrainConstruction.Controls.Add(this.switchRandomConstructor);
            this.cardTrainConstruction.Controls.Add(this.materialLabel5);
            this.cardTrainConstruction.Controls.Add(this.tbTrainName);
            this.cardTrainConstruction.Depth = 0;
            this.cardTrainConstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardTrainConstruction.Location = new System.Drawing.Point(427, 262);
            this.cardTrainConstruction.Margin = new System.Windows.Forms.Padding(14);
            this.cardTrainConstruction.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardTrainConstruction.Name = "cardTrainConstruction";
            this.cardTrainConstruction.Padding = new System.Windows.Forms.Padding(14);
            this.cardTrainConstruction.Size = new System.Drawing.Size(418, 314);
            this.cardTrainConstruction.TabIndex = 10;
            this.cardTrainConstruction.Visible = false;
            // 
            // sliderWagonsFillness
            // 
            this.sliderWagonsFillness.Depth = 0;
            this.sliderWagonsFillness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sliderWagonsFillness.Location = new System.Drawing.Point(150, 265);
            this.sliderWagonsFillness.MouseState = MaterialSkin.MouseState.HOVER;
            this.sliderWagonsFillness.Name = "sliderWagonsFillness";
            this.sliderWagonsFillness.Size = new System.Drawing.Size(250, 40);
            this.sliderWagonsFillness.TabIndex = 20;
            this.sliderWagonsFillness.Text = "Заполненность";
            // 
            // btCreateTrain
            // 
            this.btCreateTrain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCreateTrain.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btCreateTrain.Depth = 0;
            this.btCreateTrain.HighEmphasis = true;
            this.btCreateTrain.Icon = null;
            this.btCreateTrain.Location = new System.Drawing.Point(19, 265);
            this.btCreateTrain.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btCreateTrain.MouseState = MaterialSkin.MouseState.HOVER;
            this.btCreateTrain.Name = "btCreateTrain";
            this.btCreateTrain.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btCreateTrain.Size = new System.Drawing.Size(89, 36);
            this.btCreateTrain.TabIndex = 18;
            this.btCreateTrain.Text = "Создать";
            this.btCreateTrain.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btCreateTrain.UseAccentColor = false;
            this.btCreateTrain.UseVisualStyleBackColor = true;
            this.btCreateTrain.Click += new System.EventHandler(this.btCreateTrain_Click);
            // 
            // cbCargoType
            // 
            this.cbCargoType.AutoResize = false;
            this.cbCargoType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbCargoType.Depth = 0;
            this.cbCargoType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbCargoType.DropDownHeight = 174;
            this.cbCargoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargoType.DropDownWidth = 121;
            this.cbCargoType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbCargoType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbCargoType.FormattingEnabled = true;
            this.cbCargoType.Hint = "Груз";
            this.cbCargoType.IntegralHeight = false;
            this.cbCargoType.ItemHeight = 43;
            this.cbCargoType.Location = new System.Drawing.Point(216, 207);
            this.cbCargoType.MaxDropDownItems = 4;
            this.cbCargoType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbCargoType.Name = "cbCargoType";
            this.cbCargoType.Size = new System.Drawing.Size(184, 49);
            this.cbCargoType.StartIndex = 0;
            this.cbCargoType.TabIndex = 17;
            // 
            // switchIsPassengerTrain
            // 
            this.switchIsPassengerTrain.AutoSize = true;
            this.switchIsPassengerTrain.Depth = 0;
            this.switchIsPassengerTrain.Location = new System.Drawing.Point(19, 217);
            this.switchIsPassengerTrain.Margin = new System.Windows.Forms.Padding(0);
            this.switchIsPassengerTrain.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchIsPassengerTrain.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchIsPassengerTrain.Name = "switchIsPassengerTrain";
            this.switchIsPassengerTrain.Ripple = true;
            this.switchIsPassengerTrain.Size = new System.Drawing.Size(168, 37);
            this.switchIsPassengerTrain.TabIndex = 16;
            this.switchIsPassengerTrain.Text = "Пассажирский";
            this.switchIsPassengerTrain.UseVisualStyleBackColor = true;
            this.switchIsPassengerTrain.CheckedChanged += new System.EventHandler(this.switchIsPassengerTrain_CheckedChanged);
            // 
            // tbWagonsCount
            // 
            this.tbWagonsCount.AnimateReadOnly = false;
            this.tbWagonsCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbWagonsCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbWagonsCount.Depth = 0;
            this.tbWagonsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbWagonsCount.HideSelection = true;
            this.tbWagonsCount.Hint = "Кол-во вагонов";
            this.tbWagonsCount.LeadingIcon = null;
            this.tbWagonsCount.Location = new System.Drawing.Point(216, 153);
            this.tbWagonsCount.MaxLength = 32767;
            this.tbWagonsCount.MouseState = MaterialSkin.MouseState.OUT;
            this.tbWagonsCount.Name = "tbWagonsCount";
            this.tbWagonsCount.PasswordChar = '\0';
            this.tbWagonsCount.PrefixSuffixText = null;
            this.tbWagonsCount.ReadOnly = false;
            this.tbWagonsCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbWagonsCount.SelectedText = "";
            this.tbWagonsCount.SelectionLength = 0;
            this.tbWagonsCount.SelectionStart = 0;
            this.tbWagonsCount.ShortcutsEnabled = true;
            this.tbWagonsCount.Size = new System.Drawing.Size(184, 48);
            this.tbWagonsCount.TabIndex = 15;
            this.tbWagonsCount.TabStop = false;
            this.tbWagonsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbWagonsCount.TrailingIcon = null;
            this.tbWagonsCount.UseSystemPasswordChar = false;
            // 
            // tbTrainPower
            // 
            this.tbTrainPower.AnimateReadOnly = false;
            this.tbTrainPower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbTrainPower.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbTrainPower.Depth = 0;
            this.tbTrainPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTrainPower.HideSelection = true;
            this.tbTrainPower.Hint = "Мощность (кВт)";
            this.tbTrainPower.LeadingIcon = null;
            this.tbTrainPower.Location = new System.Drawing.Point(19, 153);
            this.tbTrainPower.MaxLength = 32767;
            this.tbTrainPower.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTrainPower.Name = "tbTrainPower";
            this.tbTrainPower.PasswordChar = '\0';
            this.tbTrainPower.PrefixSuffixText = null;
            this.tbTrainPower.ReadOnly = false;
            this.tbTrainPower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTrainPower.SelectedText = "";
            this.tbTrainPower.SelectionLength = 0;
            this.tbTrainPower.SelectionStart = 0;
            this.tbTrainPower.ShortcutsEnabled = true;
            this.tbTrainPower.Size = new System.Drawing.Size(191, 48);
            this.tbTrainPower.TabIndex = 14;
            this.tbTrainPower.TabStop = false;
            this.tbTrainPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTrainPower.TrailingIcon = null;
            this.tbTrainPower.UseSystemPasswordChar = false;
            // 
            // btGenerateTrainParams
            // 
            this.btGenerateTrainParams.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btGenerateTrainParams.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btGenerateTrainParams.Depth = 0;
            this.btGenerateTrainParams.Enabled = false;
            this.btGenerateTrainParams.HighEmphasis = true;
            this.btGenerateTrainParams.Icon = null;
            this.btGenerateTrainParams.Location = new System.Drawing.Point(257, 103);
            this.btGenerateTrainParams.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btGenerateTrainParams.MouseState = MaterialSkin.MouseState.HOVER;
            this.btGenerateTrainParams.Name = "btGenerateTrainParams";
            this.btGenerateTrainParams.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btGenerateTrainParams.Size = new System.Drawing.Size(143, 36);
            this.btGenerateTrainParams.TabIndex = 13;
            this.btGenerateTrainParams.Text = "Сгенерировать";
            this.btGenerateTrainParams.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btGenerateTrainParams.UseAccentColor = false;
            this.btGenerateTrainParams.UseVisualStyleBackColor = true;
            this.btGenerateTrainParams.Click += new System.EventHandler(this.btGenerateTrainParams_Click);
            // 
            // switchRandomConstructor
            // 
            this.switchRandomConstructor.AutoSize = true;
            this.switchRandomConstructor.Depth = 0;
            this.switchRandomConstructor.Location = new System.Drawing.Point(19, 103);
            this.switchRandomConstructor.Margin = new System.Windows.Forms.Padding(0);
            this.switchRandomConstructor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchRandomConstructor.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchRandomConstructor.Name = "switchRandomConstructor";
            this.switchRandomConstructor.Ripple = true;
            this.switchRandomConstructor.Size = new System.Drawing.Size(220, 37);
            this.switchRandomConstructor.TabIndex = 12;
            this.switchRandomConstructor.Text = "Рандомные значения";
            this.switchRandomConstructor.UseVisualStyleBackColor = true;
            this.switchRandomConstructor.CheckedChanged += new System.EventHandler(this.switchRandomConstructor_CheckedChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(19, 8);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(191, 24);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Конструктор поезда";
            // 
            // tbTrainName
            // 
            this.tbTrainName.AnimateReadOnly = false;
            this.tbTrainName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbTrainName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbTrainName.Depth = 0;
            this.tbTrainName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTrainName.HideSelection = true;
            this.tbTrainName.Hint = "Название поезда";
            this.tbTrainName.LeadingIcon = null;
            this.tbTrainName.Location = new System.Drawing.Point(17, 46);
            this.tbTrainName.MaxLength = 32767;
            this.tbTrainName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTrainName.Name = "tbTrainName";
            this.tbTrainName.PasswordChar = '\0';
            this.tbTrainName.PrefixSuffixText = null;
            this.tbTrainName.ReadOnly = false;
            this.tbTrainName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTrainName.SelectedText = "";
            this.tbTrainName.SelectionLength = 0;
            this.tbTrainName.SelectionStart = 0;
            this.tbTrainName.ShortcutsEnabled = true;
            this.tbTrainName.Size = new System.Drawing.Size(383, 48);
            this.tbTrainName.TabIndex = 1;
            this.tbTrainName.TabStop = false;
            this.tbTrainName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTrainName.TrailingIcon = null;
            this.tbTrainName.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialButton2);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.btDeleteTrain);
            this.materialCard1.Controls.Add(this.btAddTrain);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(427, 162);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(580, 95);
            this.materialCard1.TabIndex = 9;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(216, 44);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(154, 36);
            this.materialButton2.TabIndex = 11;
            this.materialButton2.Text = "Изменить поезд";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(19, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(130, 24);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Инструменты";
            // 
            // btDeleteTrain
            // 
            this.btDeleteTrain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDeleteTrain.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btDeleteTrain.Depth = 0;
            this.btDeleteTrain.HighEmphasis = true;
            this.btDeleteTrain.Icon = null;
            this.btDeleteTrain.Location = new System.Drawing.Point(419, 44);
            this.btDeleteTrain.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDeleteTrain.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDeleteTrain.Name = "btDeleteTrain";
            this.btDeleteTrain.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btDeleteTrain.Size = new System.Drawing.Size(143, 36);
            this.btDeleteTrain.TabIndex = 9;
            this.btDeleteTrain.Text = "Удалить поезд";
            this.btDeleteTrain.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btDeleteTrain.UseAccentColor = false;
            this.btDeleteTrain.UseVisualStyleBackColor = true;
            // 
            // btAddTrain
            // 
            this.btAddTrain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddTrain.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btAddTrain.Depth = 0;
            this.btAddTrain.HighEmphasis = true;
            this.btAddTrain.Icon = null;
            this.btAddTrain.Location = new System.Drawing.Point(19, 44);
            this.btAddTrain.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddTrain.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddTrain.Name = "btAddTrain";
            this.btAddTrain.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btAddTrain.Size = new System.Drawing.Size(152, 36);
            this.btAddTrain.TabIndex = 8;
            this.btAddTrain.Text = "Добавить поезд";
            this.btAddTrain.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAddTrain.UseAccentColor = false;
            this.btAddTrain.UseVisualStyleBackColor = true;
            this.btAddTrain.Click += new System.EventHandler(this.btAddTrain_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(6, 585);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(161, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Отправить поезд";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(427, 10);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(210, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Информация о поезде";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(6, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 24);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Поезда в депо";
            // 
            // tbConstructPanelTrainInfo
            // 
            this.tbConstructPanelTrainInfo.AnimateReadOnly = false;
            this.tbConstructPanelTrainInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbConstructPanelTrainInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbConstructPanelTrainInfo.Depth = 0;
            this.tbConstructPanelTrainInfo.HideSelection = true;
            this.tbConstructPanelTrainInfo.Hint = "Информация о поезде";
            this.tbConstructPanelTrainInfo.Location = new System.Drawing.Point(427, 45);
            this.tbConstructPanelTrainInfo.MaxLength = 32767;
            this.tbConstructPanelTrainInfo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbConstructPanelTrainInfo.Name = "tbConstructPanelTrainInfo";
            this.tbConstructPanelTrainInfo.PasswordChar = '\0';
            this.tbConstructPanelTrainInfo.ReadOnly = true;
            this.tbConstructPanelTrainInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbConstructPanelTrainInfo.SelectedText = "";
            this.tbConstructPanelTrainInfo.SelectionLength = 0;
            this.tbConstructPanelTrainInfo.SelectionStart = 0;
            this.tbConstructPanelTrainInfo.ShortcutsEnabled = true;
            this.tbConstructPanelTrainInfo.Size = new System.Drawing.Size(580, 100);
            this.tbConstructPanelTrainInfo.TabIndex = 3;
            this.tbConstructPanelTrainInfo.TabStop = false;
            this.tbConstructPanelTrainInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbConstructPanelTrainInfo.UseSystemPasswordChar = false;
            // 
            // iconsImageList
            // 
            this.iconsImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsImageList.ImageStream")));
            this.iconsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsImageList.Images.SetKeyName(0, "garage_home_48.png");
            this.iconsImageList.Images.SetKeyName(1, "build_48.png");
            this.iconsImageList.Images.SetKeyName(2, "train_48.png");
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1075, 700);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Депо";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.tabPageBuild.ResumeLayout(false);
            this.tabPageBuild.PerformLayout();
            this.cardTrainConstruction.ResumeLayout(false);
            this.cardTrainConstruction.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPageHome;
        private TabPage tabPageBuild;
        private ImageList iconsImageList;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbConstructPanelTrainInfo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialListView lvTrainsOutOfDepo;
        private ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbLogs;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 tbMainPanelTrainInfo;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btDeleteTrain;
        private MaterialSkin.Controls.MaterialButton btAddTrain;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard cardTrainConstruction;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btGenerateTrainParams;
        private MaterialSkin.Controls.MaterialSwitch switchRandomConstructor;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox2 tbTrainName;
        private MaterialSkin.Controls.MaterialTextBox2 tbTrainPower;
        private MaterialSkin.Controls.MaterialSwitch switchIsPassengerTrain;
        private MaterialSkin.Controls.MaterialTextBox2 tbWagonsCount;
        private MaterialSkin.Controls.MaterialButton btCreateTrain;
        private MaterialSkin.Controls.MaterialComboBox cbCargoType;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialSlider sliderWagonsFillness;
        private MaterialSkin.Controls.MaterialListBox lbTrainsInDepo;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}