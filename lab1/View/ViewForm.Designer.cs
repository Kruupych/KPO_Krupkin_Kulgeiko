namespace RailwayTransport.View
{
    partial class ViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            comboTrains = new ComboBox();
            buttonAddTrain = new Button();
            text_wagon = new TextBox();
            label1 = new Label();
            label2 = new Label();
            text_train = new TextBox();
            buttonAddDepo = new Button();
            comboDepoes = new ComboBox();
            buttonAddToDepo = new Button();
            buttonDelFromDepo = new Button();
            richTextView = new RichTextBox();
            buttonDelDepo = new Button();
            buttonDelTrain = new Button();
            buttonSort = new Button();
            buttonSearch = new Button();
            buttonCleanScr = new Button();
            comboSortType = new ComboBox();
            comboSearchType = new ComboBox();
            textSearchValue = new TextBox();
            SuspendLayout();
            // 
            // comboTrains
            // 
            comboTrains.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTrains.FormattingEnabled = true;
            comboTrains.Location = new Point(13, 186);
            comboTrains.Margin = new Padding(4);
            comboTrains.Name = "comboTrains";
            comboTrains.Size = new Size(200, 30);
            comboTrains.TabIndex = 0;
            // 
            // buttonAddTrain
            // 
            buttonAddTrain.Location = new Point(13, 9);
            buttonAddTrain.Margin = new Padding(4);
            buttonAddTrain.Name = "buttonAddTrain";
            buttonAddTrain.Size = new Size(200, 30);
            buttonAddTrain.TabIndex = 1;
            buttonAddTrain.Text = "Добавить поезд";
            buttonAddTrain.UseVisualStyleBackColor = true;
            buttonAddTrain.Click += buttonAddTrain_Click;
            // 
            // text_wagon
            // 
            text_wagon.Location = new Point(13, 74);
            text_wagon.Margin = new Padding(4);
            text_wagon.Name = "text_wagon";
            text_wagon.Size = new Size(200, 30);
            text_wagon.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 22);
            label1.TabIndex = 3;
            label1.Text = "Количество вагонов:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 22);
            label2.TabIndex = 6;
            label2.Text = "Количество поездов:";
            // 
            // text_train
            // 
            text_train.Location = new Point(292, 78);
            text_train.Margin = new Padding(4);
            text_train.Name = "text_train";
            text_train.Size = new Size(200, 30);
            text_train.TabIndex = 5;
            // 
            // buttonAddDepo
            // 
            buttonAddDepo.Location = new Point(292, 13);
            buttonAddDepo.Margin = new Padding(4);
            buttonAddDepo.Name = "buttonAddDepo";
            buttonAddDepo.Size = new Size(200, 30);
            buttonAddDepo.TabIndex = 4;
            buttonAddDepo.Text = "Добавить депо";
            buttonAddDepo.UseVisualStyleBackColor = true;
            buttonAddDepo.Click += buttonAddDepo_Click;
            // 
            // comboDepoes
            // 
            comboDepoes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDepoes.FormattingEnabled = true;
            comboDepoes.Location = new Point(292, 186);
            comboDepoes.Margin = new Padding(4);
            comboDepoes.Name = "comboDepoes";
            comboDepoes.Size = new Size(200, 30);
            comboDepoes.TabIndex = 7;
            // 
            // buttonAddToDepo
            // 
            buttonAddToDepo.Location = new Point(13, 148);
            buttonAddToDepo.Margin = new Padding(4);
            buttonAddToDepo.Name = "buttonAddToDepo";
            buttonAddToDepo.Size = new Size(200, 30);
            buttonAddToDepo.TabIndex = 8;
            buttonAddToDepo.Text = "Добавить в депо";
            buttonAddToDepo.UseVisualStyleBackColor = true;
            buttonAddToDepo.Click += button1_Click;
            // 
            // buttonDelFromDepo
            // 
            buttonDelFromDepo.Location = new Point(292, 148);
            buttonDelFromDepo.Margin = new Padding(4);
            buttonDelFromDepo.Name = "buttonDelFromDepo";
            buttonDelFromDepo.Size = new Size(200, 30);
            buttonDelFromDepo.TabIndex = 9;
            buttonDelFromDepo.Text = "Удалить из депо";
            buttonDelFromDepo.UseVisualStyleBackColor = true;
            buttonDelFromDepo.Click += button2_Click;
            // 
            // richTextView
            // 
            richTextView.Location = new Point(759, 9);
            richTextView.Name = "richTextView";
            richTextView.Size = new Size(719, 882);
            richTextView.TabIndex = 10;
            richTextView.Text = "";
            // 
            // buttonDelDepo
            // 
            buttonDelDepo.Location = new Point(538, 148);
            buttonDelDepo.Margin = new Padding(4);
            buttonDelDepo.Name = "buttonDelDepo";
            buttonDelDepo.Size = new Size(200, 30);
            buttonDelDepo.TabIndex = 11;
            buttonDelDepo.Text = "Удалить  депо";
            buttonDelDepo.UseVisualStyleBackColor = true;
            buttonDelDepo.Click += buttonDelDepo_Click;
            // 
            // buttonDelTrain
            // 
            buttonDelTrain.Location = new Point(538, 185);
            buttonDelTrain.Margin = new Padding(4);
            buttonDelTrain.Name = "buttonDelTrain";
            buttonDelTrain.Size = new Size(200, 30);
            buttonDelTrain.TabIndex = 12;
            buttonDelTrain.Text = "Удалить поезд";
            buttonDelTrain.UseVisualStyleBackColor = true;
            buttonDelTrain.Click += buttonDelTrain_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(538, 238);
            buttonSort.Margin = new Padding(4);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(200, 30);
            buttonSort.TabIndex = 13;
            buttonSort.Text = "Сортировать";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(13, 238);
            buttonSearch.Margin = new Padding(4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(200, 30);
            buttonSearch.TabIndex = 14;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonCleanScr
            // 
            buttonCleanScr.Location = new Point(13, 848);
            buttonCleanScr.Margin = new Padding(4);
            buttonCleanScr.Name = "buttonCleanScr";
            buttonCleanScr.Size = new Size(200, 30);
            buttonCleanScr.TabIndex = 15;
            buttonCleanScr.Text = "Очистить";
            buttonCleanScr.UseVisualStyleBackColor = true;
            buttonCleanScr.Click += buttonCleanScr_Click;
            // 
            // comboSortType
            // 
            comboSortType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSortType.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboSortType.FormattingEnabled = true;
            comboSortType.Items.AddRange(new object[] { "Стандартный вывод", "Сортировать по длине ", "Сортировать по весу", "Сортировать по скорости " });
            comboSortType.Location = new Point(538, 286);
            comboSortType.Margin = new Padding(4);
            comboSortType.Name = "comboSortType";
            comboSortType.Size = new Size(200, 23);
            comboSortType.TabIndex = 16;
            // 
            // comboSearchType
            // 
            comboSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSearchType.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboSearchType.FormattingEnabled = true;
            comboSearchType.Items.AddRange(new object[] { "Самый длинный", "Самый короткий", "Самый тяжелый", "Самый легкий", "Самый быстрый", "Самый медленный", "Длиннее чем", "Короче чем", "Тяжелее чем", "Легче чем", "Быстрее чем", "Медленнее чем", "Совпадение" });
            comboSearchType.Location = new Point(13, 286);
            comboSearchType.Margin = new Padding(4);
            comboSearchType.Name = "comboSearchType";
            comboSearchType.Size = new Size(200, 23);
            comboSearchType.TabIndex = 17;
            // 
            // textSearchValue
            // 
            textSearchValue.Location = new Point(13, 327);
            textSearchValue.Margin = new Padding(4);
            textSearchValue.Name = "textSearchValue";
            textSearchValue.Size = new Size(200, 30);
            textSearchValue.TabIndex = 18;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1490, 903);
            Controls.Add(textSearchValue);
            Controls.Add(comboSearchType);
            Controls.Add(comboSortType);
            Controls.Add(buttonCleanScr);
            Controls.Add(buttonSearch);
            Controls.Add(buttonSort);
            Controls.Add(buttonDelTrain);
            Controls.Add(buttonDelDepo);
            Controls.Add(richTextView);
            Controls.Add(buttonDelFromDepo);
            Controls.Add(buttonAddToDepo);
            Controls.Add(comboDepoes);
            Controls.Add(label2);
            Controls.Add(text_train);
            Controls.Add(buttonAddDepo);
            Controls.Add(label1);
            Controls.Add(text_wagon);
            Controls.Add(buttonAddTrain);
            Controls.Add(comboTrains);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ViewForm";
            Text = "Депо";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboTrains;
        private Button buttonAddTrain;
        private TextBox text_wagon;
        private Label label1;
        private Label label2;
        private TextBox text_train;
        private Button buttonAddDepo;
        private ComboBox comboDepoes;
        private Button buttonAddToDepo;
        private Button buttonDelFromDepo;
        private RichTextBox richTextView;
        private Button buttonDelDepo;
        private Button buttonDelTrain;
        private Button buttonSort;
        private Button buttonSearch;
        private Button buttonCleanScr;
        private ComboBox comboSortType;
        private ComboBox comboSearchType;
        private TextBox textSearchValue;
    }
}