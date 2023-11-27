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
            groupCreation = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            groupSelection = new GroupBox();
            groupFunction = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            groupAdmin = new GroupBox();
            label7 = new Label();
            groupCreation.SuspendLayout();
            groupSelection.SuspendLayout();
            groupFunction.SuspendLayout();
            groupAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // comboTrains
            // 
            comboTrains.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTrains.FormattingEnabled = true;
            comboTrains.Location = new Point(5, 52);
            comboTrains.Margin = new Padding(4);
            comboTrains.Name = "comboTrains";
            comboTrains.Size = new Size(200, 30);
            comboTrains.TabIndex = 0;
            // 
            // buttonAddTrain
            // 
            buttonAddTrain.Location = new Point(13, 30);
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
            text_wagon.Location = new Point(13, 95);
            text_wagon.Margin = new Padding(4);
            text_wagon.Name = "text_wagon";
            text_wagon.Size = new Size(200, 30);
            text_wagon.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 64);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 22);
            label1.TabIndex = 3;
            label1.Text = "Количество вагонов:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 22);
            label2.TabIndex = 6;
            label2.Text = "Количество поездов:";
            // 
            // text_train
            // 
            text_train.Location = new Point(233, 95);
            text_train.Margin = new Padding(4);
            text_train.Name = "text_train";
            text_train.Size = new Size(200, 30);
            text_train.TabIndex = 5;
            // 
            // buttonAddDepo
            // 
            buttonAddDepo.Location = new Point(233, 30);
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
            comboDepoes.Location = new Point(238, 52);
            comboDepoes.Margin = new Padding(4);
            comboDepoes.Name = "comboDepoes";
            comboDepoes.Size = new Size(200, 30);
            comboDepoes.TabIndex = 7;
            // 
            // buttonAddToDepo
            // 
            buttonAddToDepo.Location = new Point(14, 52);
            buttonAddToDepo.Margin = new Padding(4);
            buttonAddToDepo.Name = "buttonAddToDepo";
            buttonAddToDepo.Size = new Size(200, 70);
            buttonAddToDepo.TabIndex = 8;
            buttonAddToDepo.Text = "Добавить поезд в депо";
            buttonAddToDepo.UseVisualStyleBackColor = true;
            buttonAddToDepo.Click += button1_Click;
            // 
            // buttonDelFromDepo
            // 
            buttonDelFromDepo.Location = new Point(232, 52);
            buttonDelFromDepo.Margin = new Padding(4);
            buttonDelFromDepo.Name = "buttonDelFromDepo";
            buttonDelFromDepo.Size = new Size(200, 70);
            buttonDelFromDepo.TabIndex = 9;
            buttonDelFromDepo.Text = "Удалить поезд из депо";
            buttonDelFromDepo.UseVisualStyleBackColor = true;
            buttonDelFromDepo.Click += button2_Click;
            // 
            // richTextView
            // 
            richTextView.Location = new Point(964, 9);
            richTextView.Name = "richTextView";
            richTextView.Size = new Size(514, 882);
            richTextView.TabIndex = 10;
            richTextView.Text = "";
            // 
            // buttonDelDepo
            // 
            buttonDelDepo.Location = new Point(232, 130);
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
            buttonDelTrain.Location = new Point(14, 130);
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
            buttonSort.Location = new Point(12, 50);
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
            buttonSearch.Location = new Point(242, 50);
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
            comboSortType.Location = new Point(12, 98);
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
            comboSearchType.Location = new Point(242, 100);
            comboSearchType.Margin = new Padding(4);
            comboSearchType.Name = "comboSearchType";
            comboSearchType.Size = new Size(200, 23);
            comboSearchType.TabIndex = 17;
            // 
            // textSearchValue
            // 
            textSearchValue.Location = new Point(242, 175);
            textSearchValue.Margin = new Padding(4);
            textSearchValue.Name = "textSearchValue";
            textSearchValue.Size = new Size(200, 30);
            textSearchValue.TabIndex = 18;
            // 
            // groupCreation
            // 
            groupCreation.Controls.Add(buttonAddDepo);
            groupCreation.Controls.Add(buttonAddTrain);
            groupCreation.Controls.Add(text_wagon);
            groupCreation.Controls.Add(label1);
            groupCreation.Controls.Add(text_train);
            groupCreation.Controls.Add(label2);
            groupCreation.Location = new Point(15, 12);
            groupCreation.Name = "groupCreation";
            groupCreation.Size = new Size(444, 141);
            groupCreation.TabIndex = 19;
            groupCreation.TabStop = false;
            groupCreation.Text = "Добавление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 26);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(160, 22);
            label3.TabIndex = 7;
            label3.Text = "Выберите поезд:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 26);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 22);
            label4.TabIndex = 8;
            label4.Text = "Выберите депо:";
            // 
            // groupSelection
            // 
            groupSelection.Controls.Add(label4);
            groupSelection.Controls.Add(label3);
            groupSelection.Controls.Add(comboTrains);
            groupSelection.Controls.Add(comboDepoes);
            groupSelection.Location = new Point(15, 170);
            groupSelection.Name = "groupSelection";
            groupSelection.Size = new Size(444, 100);
            groupSelection.TabIndex = 20;
            groupSelection.TabStop = false;
            groupSelection.Text = "Выбор";
            // 
            // groupFunction
            // 
            groupFunction.Controls.Add(label6);
            groupFunction.Controls.Add(label5);
            groupFunction.Controls.Add(buttonSearch);
            groupFunction.Controls.Add(buttonSort);
            groupFunction.Controls.Add(comboSortType);
            groupFunction.Controls.Add(comboSearchType);
            groupFunction.Controls.Add(textSearchValue);
            groupFunction.Location = new Point(475, 12);
            groupFunction.Name = "groupFunction";
            groupFunction.Size = new Size(449, 258);
            groupFunction.TabIndex = 21;
            groupFunction.TabStop = false;
            groupFunction.Text = "Функции";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 26);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(380, 22);
            label6.TabIndex = 19;
            label6.Text = "Необходимо выбрать депо в окне выбора";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 127);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 44);
            label5.TabIndex = 9;
            label5.Text = "Введите значение\r\n для поиска";
            // 
            // groupAdmin
            // 
            groupAdmin.Controls.Add(label7);
            groupAdmin.Controls.Add(buttonDelDepo);
            groupAdmin.Controls.Add(buttonAddToDepo);
            groupAdmin.Controls.Add(buttonDelFromDepo);
            groupAdmin.Controls.Add(buttonDelTrain);
            groupAdmin.Location = new Point(253, 297);
            groupAdmin.Name = "groupAdmin";
            groupAdmin.Size = new Size(439, 173);
            groupAdmin.TabIndex = 22;
            groupAdmin.TabStop = false;
            groupAdmin.Text = "Управление";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 26);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(380, 22);
            label7.TabIndex = 20;
            label7.Text = "Необходимо выбрать депо в окне выбора";
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1490, 903);
            Controls.Add(groupAdmin);
            Controls.Add(groupFunction);
            Controls.Add(groupSelection);
            Controls.Add(groupCreation);
            Controls.Add(buttonCleanScr);
            Controls.Add(richTextView);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "ViewForm";
            Text = "Депо";
            groupCreation.ResumeLayout(false);
            groupCreation.PerformLayout();
            groupSelection.ResumeLayout(false);
            groupSelection.PerformLayout();
            groupFunction.ResumeLayout(false);
            groupFunction.PerformLayout();
            groupAdmin.ResumeLayout(false);
            groupAdmin.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupCreation;
        private Label label3;
        private Label label4;
        private GroupBox groupSelection;
        private GroupBox groupFunction;
        private Label label6;
        private Label label5;
        private GroupBox groupAdmin;
        private Label label7;
    }
}