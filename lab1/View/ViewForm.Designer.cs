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
            bt_changeLanguage = new Button();
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
            resources.ApplyResources(comboTrains, "comboTrains");
            comboTrains.Name = "comboTrains";
            // 
            // buttonAddTrain
            // 
            resources.ApplyResources(buttonAddTrain, "buttonAddTrain");
            buttonAddTrain.Name = "buttonAddTrain";
            buttonAddTrain.UseVisualStyleBackColor = true;
            buttonAddTrain.Click += buttonAddTrain_Click;
            // 
            // text_wagon
            // 
            resources.ApplyResources(text_wagon, "text_wagon");
            text_wagon.Name = "text_wagon";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // text_train
            // 
            resources.ApplyResources(text_train, "text_train");
            text_train.Name = "text_train";
            // 
            // buttonAddDepo
            // 
            resources.ApplyResources(buttonAddDepo, "buttonAddDepo");
            buttonAddDepo.Name = "buttonAddDepo";
            buttonAddDepo.UseVisualStyleBackColor = true;
            buttonAddDepo.Click += buttonAddDepo_Click;
            // 
            // comboDepoes
            // 
            comboDepoes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDepoes.FormattingEnabled = true;
            resources.ApplyResources(comboDepoes, "comboDepoes");
            comboDepoes.Name = "comboDepoes";
            // 
            // buttonAddToDepo
            // 
            resources.ApplyResources(buttonAddToDepo, "buttonAddToDepo");
            buttonAddToDepo.Name = "buttonAddToDepo";
            buttonAddToDepo.UseVisualStyleBackColor = true;
            buttonAddToDepo.Click += button1_Click;
            // 
            // buttonDelFromDepo
            // 
            resources.ApplyResources(buttonDelFromDepo, "buttonDelFromDepo");
            buttonDelFromDepo.Name = "buttonDelFromDepo";
            buttonDelFromDepo.UseVisualStyleBackColor = true;
            buttonDelFromDepo.Click += button2_Click;
            // 
            // richTextView
            // 
            resources.ApplyResources(richTextView, "richTextView");
            richTextView.Name = "richTextView";
            // 
            // buttonDelDepo
            // 
            resources.ApplyResources(buttonDelDepo, "buttonDelDepo");
            buttonDelDepo.Name = "buttonDelDepo";
            buttonDelDepo.UseVisualStyleBackColor = true;
            buttonDelDepo.Click += buttonDelDepo_Click;
            // 
            // buttonDelTrain
            // 
            resources.ApplyResources(buttonDelTrain, "buttonDelTrain");
            buttonDelTrain.Name = "buttonDelTrain";
            buttonDelTrain.UseVisualStyleBackColor = true;
            buttonDelTrain.Click += buttonDelTrain_Click;
            // 
            // buttonSort
            // 
            resources.ApplyResources(buttonSort, "buttonSort");
            buttonSort.Name = "buttonSort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // buttonSearch
            // 
            resources.ApplyResources(buttonSearch, "buttonSearch");
            buttonSearch.Name = "buttonSearch";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonCleanScr
            // 
            resources.ApplyResources(buttonCleanScr, "buttonCleanScr");
            buttonCleanScr.Name = "buttonCleanScr";
            buttonCleanScr.UseVisualStyleBackColor = true;
            buttonCleanScr.Click += buttonCleanScr_Click;
            // 
            // comboSortType
            // 
            comboSortType.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(comboSortType, "comboSortType");
            comboSortType.FormattingEnabled = true;
            comboSortType.Items.AddRange(new object[] { resources.GetString("comboSortType.Items"), resources.GetString("comboSortType.Items1"), resources.GetString("comboSortType.Items2"), resources.GetString("comboSortType.Items3") });
            comboSortType.Name = "comboSortType";
            // 
            // comboSearchType
            // 
            comboSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(comboSearchType, "comboSearchType");
            comboSearchType.FormattingEnabled = true;
            comboSearchType.Items.AddRange(new object[] { resources.GetString("comboSearchType.Items"), resources.GetString("comboSearchType.Items1"), resources.GetString("comboSearchType.Items2"), resources.GetString("comboSearchType.Items3"), resources.GetString("comboSearchType.Items4"), resources.GetString("comboSearchType.Items5"), resources.GetString("comboSearchType.Items6"), resources.GetString("comboSearchType.Items7"), resources.GetString("comboSearchType.Items8"), resources.GetString("comboSearchType.Items9"), resources.GetString("comboSearchType.Items10"), resources.GetString("comboSearchType.Items11"), resources.GetString("comboSearchType.Items12") });
            comboSearchType.Name = "comboSearchType";
            // 
            // textSearchValue
            // 
            resources.ApplyResources(textSearchValue, "textSearchValue");
            textSearchValue.Name = "textSearchValue";
            // 
            // groupCreation
            // 
            groupCreation.Controls.Add(buttonAddDepo);
            groupCreation.Controls.Add(buttonAddTrain);
            groupCreation.Controls.Add(text_wagon);
            groupCreation.Controls.Add(label1);
            groupCreation.Controls.Add(text_train);
            groupCreation.Controls.Add(label2);
            resources.ApplyResources(groupCreation, "groupCreation");
            groupCreation.Name = "groupCreation";
            groupCreation.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // groupSelection
            // 
            groupSelection.Controls.Add(label4);
            groupSelection.Controls.Add(label3);
            groupSelection.Controls.Add(comboTrains);
            groupSelection.Controls.Add(comboDepoes);
            resources.ApplyResources(groupSelection, "groupSelection");
            groupSelection.Name = "groupSelection";
            groupSelection.TabStop = false;
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
            resources.ApplyResources(groupFunction, "groupFunction");
            groupFunction.Name = "groupFunction";
            groupFunction.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // groupAdmin
            // 
            groupAdmin.Controls.Add(label7);
            groupAdmin.Controls.Add(buttonDelDepo);
            groupAdmin.Controls.Add(buttonAddToDepo);
            groupAdmin.Controls.Add(buttonDelFromDepo);
            groupAdmin.Controls.Add(buttonDelTrain);
            resources.ApplyResources(groupAdmin, "groupAdmin");
            groupAdmin.Name = "groupAdmin";
            groupAdmin.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // bt_changeLanguage
            // 
            resources.ApplyResources(bt_changeLanguage, "bt_changeLanguage");
            bt_changeLanguage.Name = "bt_changeLanguage";
            bt_changeLanguage.UseVisualStyleBackColor = true;
            bt_changeLanguage.Click += bt_changeLanguage_Click;
            // 
            // ViewForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            Controls.Add(bt_changeLanguage);
            Controls.Add(groupAdmin);
            Controls.Add(groupFunction);
            Controls.Add(groupSelection);
            Controls.Add(groupCreation);
            Controls.Add(buttonCleanScr);
            Controls.Add(richTextView);
            Name = "ViewForm";
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
        private Button bt_changeLanguage;
    }
}