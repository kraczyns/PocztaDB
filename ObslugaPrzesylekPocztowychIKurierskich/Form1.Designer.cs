namespace ObslugaPrzesylekPocztowychIKurierskich
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.postTab = new System.Windows.Forms.TabControl();
            this.messageTab = new System.Windows.Forms.TabPage();
            this.messangerTab = new System.Windows.Forms.TabPage();
            this.carTab = new System.Windows.Forms.TabPage();
            this.graphicTab = new System.Windows.Forms.TabPage();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.editMsgButton = new System.Windows.Forms.Button();
            this.deleteMsgButton = new System.Windows.Forms.Button();
            this.deleteAllMsgButton = new System.Windows.Forms.Button();
            this.addMsgButton = new System.Windows.Forms.Button();
            this.addMsngButton = new System.Windows.Forms.Button();
            this.deleteAllMsngButton = new System.Windows.Forms.Button();
            this.deleteMsngButton = new System.Windows.Forms.Button();
            this.editMsngButton = new System.Windows.Forms.Button();
            this.messangerListBox = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.postTab.SuspendLayout();
            this.messageTab.SuspendLayout();
            this.messangerTab.SuspendLayout();
            this.carTab.SuspendLayout();
            this.graphicTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(-2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Obsługa Przesyłek Pocztowych i Kurierskich";
            // 
            // postTab
            // 
            this.postTab.Controls.Add(this.messageTab);
            this.postTab.Controls.Add(this.messangerTab);
            this.postTab.Controls.Add(this.carTab);
            this.postTab.Controls.Add(this.graphicTab);
            this.postTab.Location = new System.Drawing.Point(12, 59);
            this.postTab.Name = "postTab";
            this.postTab.SelectedIndex = 0;
            this.postTab.Size = new System.Drawing.Size(453, 345);
            this.postTab.TabIndex = 1;
            // 
            // messageTab
            // 
            this.messageTab.Controls.Add(this.addMsgButton);
            this.messageTab.Controls.Add(this.deleteAllMsgButton);
            this.messageTab.Controls.Add(this.deleteMsgButton);
            this.messageTab.Controls.Add(this.editMsgButton);
            this.messageTab.Controls.Add(this.messageListBox);
            this.messageTab.Location = new System.Drawing.Point(4, 22);
            this.messageTab.Name = "messageTab";
            this.messageTab.Padding = new System.Windows.Forms.Padding(3);
            this.messageTab.Size = new System.Drawing.Size(445, 319);
            this.messageTab.TabIndex = 0;
            this.messageTab.Text = "Przesyłka";
            this.messageTab.UseVisualStyleBackColor = true;
            // 
            // messangerTab
            // 
            this.messangerTab.Controls.Add(this.addMsngButton);
            this.messangerTab.Controls.Add(this.deleteAllMsngButton);
            this.messangerTab.Controls.Add(this.deleteMsngButton);
            this.messangerTab.Controls.Add(this.editMsngButton);
            this.messangerTab.Controls.Add(this.messangerListBox);
            this.messangerTab.Location = new System.Drawing.Point(4, 22);
            this.messangerTab.Name = "messangerTab";
            this.messangerTab.Padding = new System.Windows.Forms.Padding(3);
            this.messangerTab.Size = new System.Drawing.Size(445, 319);
            this.messangerTab.TabIndex = 1;
            this.messangerTab.Text = "Kurier";
            this.messangerTab.UseVisualStyleBackColor = true;
            // 
            // carTab
            // 
            this.carTab.Controls.Add(this.button5);
            this.carTab.Controls.Add(this.button6);
            this.carTab.Controls.Add(this.button7);
            this.carTab.Controls.Add(this.button8);
            this.carTab.Controls.Add(this.listBox2);
            this.carTab.Location = new System.Drawing.Point(4, 22);
            this.carTab.Name = "carTab";
            this.carTab.Padding = new System.Windows.Forms.Padding(3);
            this.carTab.Size = new System.Drawing.Size(445, 319);
            this.carTab.TabIndex = 2;
            this.carTab.Text = "Pojazd";
            this.carTab.UseVisualStyleBackColor = true;
            // 
            // graphicTab
            // 
            this.graphicTab.Controls.Add(this.button9);
            this.graphicTab.Controls.Add(this.button10);
            this.graphicTab.Controls.Add(this.button11);
            this.graphicTab.Controls.Add(this.button12);
            this.graphicTab.Controls.Add(this.listBox3);
            this.graphicTab.Location = new System.Drawing.Point(4, 22);
            this.graphicTab.Name = "graphicTab";
            this.graphicTab.Padding = new System.Windows.Forms.Padding(3);
            this.graphicTab.Size = new System.Drawing.Size(445, 319);
            this.graphicTab.TabIndex = 3;
            this.graphicTab.Text = "Grafik";
            this.graphicTab.UseVisualStyleBackColor = true;
            // 
            // messageListBox
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.Location = new System.Drawing.Point(23, 17);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(403, 173);
            this.messageListBox.TabIndex = 0;
            // 
            // editMsgButton
            // 
            this.editMsgButton.Location = new System.Drawing.Point(23, 209);
            this.editMsgButton.Name = "editMsgButton";
            this.editMsgButton.Size = new System.Drawing.Size(235, 25);
            this.editMsgButton.TabIndex = 1;
            this.editMsgButton.Text = "Edytuj";
            this.editMsgButton.UseVisualStyleBackColor = true;
            // 
            // deleteMsgButton
            // 
            this.deleteMsgButton.Location = new System.Drawing.Point(23, 240);
            this.deleteMsgButton.Name = "deleteMsgButton";
            this.deleteMsgButton.Size = new System.Drawing.Size(235, 23);
            this.deleteMsgButton.TabIndex = 2;
            this.deleteMsgButton.Text = "Usuń";
            this.deleteMsgButton.UseVisualStyleBackColor = true;
            // 
            // deleteAllMsgButton
            // 
            this.deleteAllMsgButton.Location = new System.Drawing.Point(286, 209);
            this.deleteAllMsgButton.Name = "deleteAllMsgButton";
            this.deleteAllMsgButton.Size = new System.Drawing.Size(140, 54);
            this.deleteAllMsgButton.TabIndex = 3;
            this.deleteAllMsgButton.Text = "Usuń wszystko";
            this.deleteAllMsgButton.UseVisualStyleBackColor = true;
            // 
            // addMsgButton
            // 
            this.addMsgButton.Location = new System.Drawing.Point(155, 274);
            this.addMsgButton.Name = "addMsgButton";
            this.addMsgButton.Size = new System.Drawing.Size(127, 39);
            this.addMsgButton.TabIndex = 4;
            this.addMsgButton.Text = "Dodaj";
            this.addMsgButton.UseVisualStyleBackColor = true;
            this.addMsgButton.Click += new System.EventHandler(this.addMsgButton_Click);
            // 
            // addMsngButton
            // 
            this.addMsngButton.Location = new System.Drawing.Point(153, 273);
            this.addMsngButton.Name = "addMsngButton";
            this.addMsngButton.Size = new System.Drawing.Size(127, 39);
            this.addMsngButton.TabIndex = 9;
            this.addMsngButton.Text = "Dodaj";
            this.addMsngButton.UseVisualStyleBackColor = true;
            // 
            // deleteAllMsngButton
            // 
            this.deleteAllMsngButton.Location = new System.Drawing.Point(284, 208);
            this.deleteAllMsngButton.Name = "deleteAllMsngButton";
            this.deleteAllMsngButton.Size = new System.Drawing.Size(140, 54);
            this.deleteAllMsngButton.TabIndex = 8;
            this.deleteAllMsngButton.Text = "Usuń wszystko";
            this.deleteAllMsngButton.UseVisualStyleBackColor = true;
            // 
            // deleteMsngButton
            // 
            this.deleteMsngButton.Location = new System.Drawing.Point(21, 239);
            this.deleteMsngButton.Name = "deleteMsngButton";
            this.deleteMsngButton.Size = new System.Drawing.Size(235, 23);
            this.deleteMsngButton.TabIndex = 7;
            this.deleteMsngButton.Text = "Usuń";
            this.deleteMsngButton.UseVisualStyleBackColor = true;
            // 
            // editMsngButton
            // 
            this.editMsngButton.Location = new System.Drawing.Point(21, 208);
            this.editMsngButton.Name = "editMsngButton";
            this.editMsngButton.Size = new System.Drawing.Size(235, 25);
            this.editMsngButton.TabIndex = 6;
            this.editMsngButton.Text = "Edytuj";
            this.editMsngButton.UseVisualStyleBackColor = true;
            // 
            // messangerListBox
            // 
            this.messangerListBox.FormattingEnabled = true;
            this.messangerListBox.Location = new System.Drawing.Point(21, 16);
            this.messangerListBox.Name = "messangerListBox";
            this.messangerListBox.Size = new System.Drawing.Size(403, 173);
            this.messangerListBox.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(153, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(127, 39);
            this.button5.TabIndex = 9;
            this.button5.Text = "Dodaj";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(284, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 54);
            this.button6.TabIndex = 8;
            this.button6.Text = "Usuń wszystko";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 234);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(235, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Usuń";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(21, 203);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(235, 25);
            this.button8.TabIndex = 6;
            this.button8.Text = "Edytuj";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(21, 11);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(403, 173);
            this.listBox2.TabIndex = 5;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(153, 268);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(127, 39);
            this.button9.TabIndex = 9;
            this.button9.Text = "Dodaj";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(284, 203);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(140, 54);
            this.button10.TabIndex = 8;
            this.button10.Text = "Usuń wszystko";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(21, 234);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(235, 23);
            this.button11.TabIndex = 7;
            this.button11.Text = "Usuń";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(21, 203);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(235, 25);
            this.button12.TabIndex = 6;
            this.button12.Text = "Edytuj";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(21, 11);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(403, 173);
            this.listBox3.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 406);
            this.Controls.Add(this.postTab);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.postTab.ResumeLayout(false);
            this.messageTab.ResumeLayout(false);
            this.messangerTab.ResumeLayout(false);
            this.carTab.ResumeLayout(false);
            this.graphicTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl postTab;
        private System.Windows.Forms.TabPage messageTab;
        private System.Windows.Forms.TabPage messangerTab;
        private System.Windows.Forms.TabPage carTab;
        private System.Windows.Forms.TabPage graphicTab;
        private System.Windows.Forms.Button addMsgButton;
        private System.Windows.Forms.Button deleteAllMsgButton;
        private System.Windows.Forms.Button deleteMsgButton;
        private System.Windows.Forms.Button editMsgButton;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.Button addMsngButton;
        private System.Windows.Forms.Button deleteAllMsngButton;
        private System.Windows.Forms.Button deleteMsngButton;
        private System.Windows.Forms.Button editMsngButton;
        private System.Windows.Forms.ListBox messangerListBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ListBox listBox3;
    }
}

